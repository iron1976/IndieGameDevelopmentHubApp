# IndieGameDevelopmentHubApp
CMPE232 PROJECT AS .NET FORM 
Github Link: https://github.com/iron1976/IndieGameDevelopmentHubApp/tree/main

![Alt text](In%20App%20Screenshots/gameHub1jpg)
![Alt text](In%20App%20Screenshots/gameHub2jpg)
![Alt text](In%20App%20Screenshots/gameHub3jpg)
![Alt text](In%20App%20Screenshots/gameHub4jpg)
![Alt text](In%20App%20Screenshots/gameHub5jpg)
![Alt text](In%20App%20Screenshots/gameHub6jpg)
![Alt text](In%20App%20Screenshots/gameHub7jpg)
![Alt text](In%20App%20Screenshots/gameHub8jpg)
![Alt text](In%20App%20Screenshots/gameHub9jpg)
![Alt text](In%20App%20Screenshots/gameHub10.jpg)
![Alt text](In%20App%20Screenshots/gameHub11.jpg)
![Alt text](In%20App%20Screenshots/gameHub12.jpg)







Used .Net Form
EntityFramework – 6.5.1  
Microsoft.AspNetCore.Components.QuickGrid.EntityFrameworkAdapter – 9.0.5   
Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore – 9.0.5   
Microsoft.AspNetCore.Identity.EntityFrameworkCore – 9.0.5   
Microsoft.EntityFrameworkCore.SqlServer – 9.0.5   
Microsoft.EntityFrameworkCore.Tools – 9.0.5  
WinForms.DataVisualization – 1.1.0   


#First open SQL Server Management Studio 20<br>
1: Create database called IndieGameDevelopmentHub as localhost<br>
2: Then open RunThisSQL.sql and execute it in SQL Server Management Studio<br>
3: Now you can run application or compile from .sln.<br>
<br>
#For Updating DATABASE MODEL put this code in Package Manager Console<br>
Scaffold-DbContext "Server=localhost;Database=IndieGameDevelopmentHub;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force<br>
