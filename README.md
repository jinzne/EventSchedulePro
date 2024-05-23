
+ Register new account from https://render.com/
+ Create new PosgreSQL
![1](https://github.com/jinzne/EventSchedulePro/assets/122944917/6633c4b2-c1df-4a8c-bcd0-0c06b1b486ab)
![2](https://github.com/jinzne/EventSchedulePro/assets/122944917/d2f7e1b5-83a8-4521-a076-a337fa505667)
+ Copy
![3](https://github.com/jinzne/EventSchedulePro/assets/122944917/0c7435b7-8878-475d-b95f-e97aecca5c1c)
postgres://root:hd72s7wRDeEnOuGTNtiuWi4If1LtY1yI@dpg-cp71886v3ddc73fs8qqg-a.oregon-postgres.render.com/db_bsdb
Example:  connect string C# format postgres//{User Id}:{Password}@{Server}/{Database}
+ Open appsettings.json in source code, find "EventDB", and change it follow prev step
![4](https://github.com/jinzne/EventSchedulePro/assets/122944917/61a8667e-4ec6-4334-aca4-6f2e75af97ec)
 "EventDB": "Server={Server};Database={Database};Port=5432;User Id={User Id};Password={Password};"
Example: "Server=dpg-cp71886v3ddc73fs8qqg-a.oregon-postgres.render.com;Database=db_bsdb;Port=5432;User Id=root;Password=hd72s7wRDeEnOuGTNtiuWi4If1LtY1yI;"
+ Visual Studio -> Tools -> Nuget package manager -> Pakage manager console.
  Add-Migration InitialCreate
![5](https://github.com/jinzne/EventSchedulePro/assets/122944917/071af689-ca51-473f-885c-08ee948ce7ac)
  Update-Database
![6](https://github.com/jinzne/EventSchedulePro/assets/122944917/b8f86c55-4051-4c03-9fd1-3786201f9d3e)

=> Done setup Database Posgre.

Setup key api TinyMCE:
+ Open _Layout.cshtml, find
  <script src="https://cdn.tiny.cloud/1/hq5vs4y7vejecx3frt0fsoxiqw9gparwxycvye5luungp5br/tinymce/7/tinymce.min.js" referrerpolicy="origin"></script>
  It format like <script src="https://cdn.tiny.cloud/1/{apikey}/tinymce/7/tinymce.min.js" referrerpolicy="origin"></script>
+ Register new account from https://www.tiny.cloud/get-tiny/
+ Find APIKEY
![7](https://github.com/jinzne/EventSchedulePro/assets/122944917/8a685897-3fcd-4d0c-9db4-db7576a4a25a)
replace this apikey into <script src="https://cdn.tiny.cloud/1/{apikey}/tinymce/7/tinymce.min.js" referrerpolicy="origin"></script>, and save sourcecode.

+ Upload sourcecode into github.
+ Back to https://render.com/, create new Webservice
![8](https://github.com/jinzne/EventSchedulePro/assets/122944917/c34c1314-c08d-44b0-83fc-e993e80f44da)
![9](https://github.com/jinzne/EventSchedulePro/assets/122944917/19eca6a5-0825-49e0-8fe7-403c0504c5c8)
![10](https://github.com/jinzne/EventSchedulePro/assets/122944917/ff7ff062-f61a-4484-ac28-6a28ab0ead38)
Authorize Render access into github
![image](https://github.com/jinzne/EventSchedulePro/assets/122944917/1890c627-e402-40dd-ae8c-95d4b38b2ae3)
![image](https://github.com/jinzne/EventSchedulePro/assets/122944917/e560379a-9c9b-4956-8244-f2ffa215079e)
![image](https://github.com/jinzne/EventSchedulePro/assets/122944917/c61d5e22-c871-498c-a88b-35da0246ed3f)

Connect to git project from prev step.
![image](https://github.com/jinzne/EventSchedulePro/assets/122944917/5121965f-be43-4e48-81c4-a602029ff470)
![image](https://github.com/jinzne/EventSchedulePro/assets/122944917/64b789a9-bebe-45e8-93bb-c59f5a5d62ac)
Click [CREATE WEB SERVICE]
![image](https://github.com/jinzne/EventSchedulePro/assets/122944917/d8f59c02-2b3d-4ce1-8812-3022a680ce92)



