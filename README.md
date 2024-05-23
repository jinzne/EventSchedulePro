
+ Register new account from https://render.com/
+ Create new PosgreSQL
+ ![1](https://github.com/jinzne/EventSchedulePro/assets/122944917/005337cc-f258-43b8-8776-d6b351718c94)
![2](https://github.com/jinzne/EventSchedulePro/assets/122944917/250dc4f8-823a-44b1-98a8-35b4e0834c28)
+ Copy
![3](https://github.com/jinzne/EventSchedulePro/assets/122944917/f80128ab-ccbb-4e0c-8cc4-e6521e23ef01)
postgres://root:hd72s7wRDeEnOuGTNtiuWi4If1LtY1yI@dpg-cp71886v3ddc73fs8qqg-a.oregon-postgres.render.com/db_bsdb
Example:  connect string C# format postgres//{User Id}:{Password}@{Server}/{Database}
+ Open appsettings.json in source code, find "EventDB", and change it follow prev step
![4](https://github.com/jinzne/EventSchedulePro/assets/122944917/c4c044bf-f1ef-48c0-b234-696b9e563ca7)
 "EventDB": "Server={Server};Database={Database};Port=5432;User Id={User Id};Password={Password};"
Example: "Server=dpg-cp71886v3ddc73fs8qqg-a.oregon-postgres.render.com;Database=db_bsdb;Port=5432;User Id=root;Password=hd72s7wRDeEnOuGTNtiuWi4If1LtY1yI;"
+ Visual Studio -> Tools -> Nuget package manager -> Pakage manager console.
  Add-Migration InitialCreate
![5](https://github.com/jinzne/EventSchedulePro/assets/122944917/3ae95956-74cc-4fa6-b6d1-7a0900a90ad7)
  Update-Database
![6](https://github.com/jinzne/EventSchedulePro/assets/122944917/3d76fc98-f85b-4a02-a3b7-02e9946ce862)

=> Done setup Database Posgre.

Setup key api TinyMCE:
+ Open _Layout.cshtml, find
  <script src="https://cdn.tiny.cloud/1/hq5vs4y7vejecx3frt0fsoxiqw9gparwxycvye5luungp5br/tinymce/7/tinymce.min.js" referrerpolicy="origin"></script>
  It format like <script src="https://cdn.tiny.cloud/1/{apikey}/tinymce/7/tinymce.min.js" referrerpolicy="origin"></script>
+ Register new account from https://www.tiny.cloud/get-tiny/
+ Find APIKEY
 ![7](https://github.com/jinzne/EventSchedulePro/assets/122944917/0ed7fc02-ccc7-4bc7-a7ad-d10c7de687a3)

replace this apikey into <script src="https://cdn.tiny.cloud/1/{apikey}/tinymce/7/tinymce.min.js" referrerpolicy="origin"></script>, and save sourcecode.

+ Upload sourcecode into github.
+ Back to https://render.com/, create new Webservice
![8](https://github.com/jinzne/EventSchedulePro/assets/122944917/b9c4705f-d5cc-4501-871c-a48538dad3a3)
![9](https://github.com/jinzne/EventSchedulePro/assets/122944917/4a110afa-0a5b-49a0-b6fc-e2611a53aeb0)
![10](https://github.com/jinzne/EventSchedulePro/assets/122944917/e006506b-a685-4088-905b-2f1828426688)
Connect to git project from prev step.

