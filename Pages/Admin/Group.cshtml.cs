using EventSchedulePro.Data.Context;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Linq;
using Group = EventSchedulePro.Data.Class.Group;
namespace EventSchedulePro.Pages.Admin
{
    public class GroupModel : PageModel
    { 
        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public string Id { get; set; }
            [Required]
            public string Name { get; set; }
        }

        public readonly EventDBContext _context;
        public GroupModel(EventDBContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            var userName = HttpContext.Session.GetString("AdminUserName");
            if (string.IsNullOrEmpty(userName))
            {
                return new RedirectToPageResult("/Admin/Login");
            }
            return Page();
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        [HttpPost("Save")]
        public async Task<IActionResult> OnPostSaveAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            if (!String.IsNullOrEmpty(Input.Id))
            {
                try
                {
                    int id = int.Parse(Input.Id);
                    var group = _context.Groups.Where(x => x.Id == id).FirstOrDefault();
                    if (group != null) 
                    {
                        group.Name= Input.Name;
                        _context.SaveChanges();
                        Input.Id = null;
                        Input.Name = "";
                        var staffst = _context.Staffs.Where(x => x.GroupIds.Contains(id.ToString())).ToList();
                        var groups = _context.Groups.ToList();
                        foreach(var item in staffst)
                        {
                            if (!string.IsNullOrEmpty(item.GroupIds))
                            {
                                var ListGroup = item.GroupIds.Split(",");
                                var groupName = "";
                                foreach (var itemgroup in ListGroup)
                                {
                                    var g = groups.Where(x => x.Id.ToString().CompareTo(itemgroup.Trim()) == 0).FirstOrDefault();
                                    if (g != null)
                                    {
                                        groupName += g.Name + ",";
                                    }

                                }
                                item.GroupNames=groupName;
                                _context.SaveChanges();
                            }
                        }
                    }
                }
                catch (Exception)
                {

                }
            } else if (!String.IsNullOrEmpty(Input.Name)) 
            {

                Group t = new Group();
                t.Name = Input.Name;
                t.Detail = Input.Name;
                Input.Name = "";
                _context.Groups.Add(t);
                _context.SaveChanges();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {          
            return Page();
        }
        [HttpPost("Edit")]
        public async Task<IActionResult> OnPostEditAsync(string Id = null,string Name = null)
        {
            if (Id != null)
            {
                Input.Id = Id;
                Input.Name = Name;
            }
            return Page();
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> OnPostDeleteAsync(string Id = null, string Name = null)
        {
            if (!String.IsNullOrEmpty(Input.Id))
            {
                try
                {
                    int id = int.Parse(Input.Id);
                    var group = _context.Groups.Where(x => x.Id == id).FirstOrDefault();
                    if (group != null)
                    {
                        _context.Groups.Remove(group);
                        _context.SaveChanges();
                    }
                }
                catch (Exception)
                {

                }
            }
            return Page();
        }
    }
}
