Tech use:
<br/>
![ChatGPT](https://img.shields.io/badge/chatGPT-74aa9c?style=for-the-badge&logo=openai&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Blazor](https://img.shields.io/badge/blazor-%235C2D91.svg?style=for-the-badge&logo=blazor&logoColor=white)
![Bootstrap](https://img.shields.io/badge/bootstrap-%238511FA.svg?style=for-the-badge&logo=bootstrap&logoColor=white)
![jQuery](https://img.shields.io/badge/jquery-%230769AD.svg?style=for-the-badge&logo=jquery&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![HTML5](https://img.shields.io/badge/html5-%23E34F26.svg?style=for-the-badge&logo=html5&logoColor=white)
![JavaScript](https://img.shields.io/badge/javascript-%23323330.svg?style=for-the-badge&logo=javascript&logoColor=%23F7DF1E)
![Docker](https://img.shields.io/badge/docker-%230db7ed.svg?style=for-the-badge&logo=docker&logoColor=white)
![Postgres](https://img.shields.io/badge/postgres-%23316192.svg?style=for-the-badge&logo=postgresql&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)
<br/>
Hosting:
<br/>
![Render](https://img.shields.io/badge/Render-%46E3B7.svg?style=for-the-badge&logo=render&logoColor=white)
<br/>

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
![image](https://github.com/jinzne/EventSchedulePro/assets/122944917/bececcac-65f4-4cdd-afb7-5ed88e000073)
![9](https://github.com/jinzne/EventSchedulePro/assets/122944917/19eca6a5-0825-49e0-8fe7-403c0504c5c8)
![10](https://github.com/jinzne/EventSchedulePro/assets/122944917/ff7ff062-f61a-4484-ac28-6a28ab0ead38)
Authorize Render access into github
![image](https://github.com/jinzne/EventSchedulePro/assets/122944917/1890c627-e402-40dd-ae8c-95d4b38b2ae3)
![image](https://github.com/jinzne/EventSchedulePro/assets/122944917/e560379a-9c9b-4956-8244-f2ffa215079e)
![image](https://github.com/jinzne/EventSchedulePro/assets/122944917/c61d5e22-c871-498c-a88b-35da0246ed3f)

Connect to git project from prev step.
![image](https://github.com/jinzne/EventSchedulePro/assets/122944917/e1295a6a-7db5-47e0-9d82-041668768c91)
![image](https://github.com/jinzne/EventSchedulePro/assets/122944917/64b789a9-bebe-45e8-93bb-c59f5a5d62ac)
Click [CREATE WEB SERVICE]
![image](https://github.com/jinzne/EventSchedulePro/assets/122944917/d8f59c02-2b3d-4ce1-8812-3022a680ce92)
![image](https://github.com/jinzne/EventSchedulePro/assets/122944917/39dde980-6622-4a0d-9d51-b8281a419551)

DONE.


