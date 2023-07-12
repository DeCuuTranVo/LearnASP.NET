
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Bootstrap](https://img.shields.io/badge/bootstrap-%238511FA.svg?style=for-the-badge&logo=bootstrap&logoColor=white)
![jQuery](https://img.shields.io/badge/jquery-%230769AD.svg?style=for-the-badge&logo=jquery&logoColor=white)
![JavaScript](https://img.shields.io/badge/javascript-%23323330.svg?style=for-the-badge&logo=javascript&logoColor=%23F7DF1E)
![HTML5](https://img.shields.io/badge/html5-%23E34F26.svg?style=for-the-badge&logo=html5&logoColor=white)
![CSS3](https://img.shields.io/badge/css3-%231572B6.svg?style=for-the-badge&logo=css3&logoColor=white)

# School Management App
This is my reimplementation of the School Management App in the Course [ASP.NET Core 7 MVC - Cross-Platform Development](https://www.udemy.com/course/learn-aspnet-mvc-and-entity-framework/) of Mr. Trevoir Williams.

## Technologies
<ul>
  <li>ASP.NET Core 7 MVC</li>
  <li>Entity Framework Core</li>
  <li>SQL Server</li>
  <li>Bootstrap</li>
  <li>jQuery</li>
</ul>

## Dependencies
+ AspNetCoreHero.ToastNotification=1.1.0
+ Auth0.AspNetCore.Authentication=1.2.0
+ Microsoft.EntityFrameworkCore.Design=7.0.8
+ Microsoft.EntityFrameworkCore.SqlServer=7.0.8
+ Microsoft.EntityFrameworkCore.Tools=7.0.8
+ Microsoft.VisualStudio.Web.CodeGeneration.Design=7.0.7


## Features
The project includes the following features:
- Authentication and Authorization using OAuth (one role)
- CRUD operations for students, teachers, courses
- Class registration for student's enrollments
- MVC design pattern

## Project Structure

    SchoolManagementApp.MVC
        ├── Controllers                                 (Control logics of this application)
        │   ├── AccountController.cs
        │   ├── ClassesController.cs
        │   ├── CoursesController.cs
        │   ├── HomeController.cs
        │   ├── LecturerController.cs
        │   └── StudentsController.cs
        ├── Data                                        (Data objects and database connection)
        │   ├── Class.cs
        │   ├── Courses.cs
        │   ├── Enrollment.cs
        │   ├── Lecturer.cs
        │   ├── SchoolManagementDbContext.cs            (Database context object)
        │   └── Student.cs
        ├── Models                                      (Control data of this application)
        │   ├── ClassEnrollmentViewModel.cs                                 
        │   ├── ClassMetaData.cs                 
        │   ├── ClassViewModel.cs
        │   ├── ErrorViewModel.cs
        │   ├── LecturerMetaData.cs
        │   ├── StudentEnrollmentViewModel.cs
        │   ├── StudentMetaData.cs
        │   └── UserProfileViewModel.cs
        ├── Properties
        │   └──launchSettings.json
        ├── SQLQueries                                  (SQL queries to create app's database and tables)
        │   ├── CreateClassAndEnrollmentTable.sql 
        │   └── CreateDatabaseAndMainTables.sql
        ├── Views                                       (Control views of this application)
        │   ├── Account   
        │   │   └── Profile.cshtml
        │   ├── Classes
        │   │   ├── Create.cshtml
        │   │   ├── Delete.cshtml
        │   │   ├── Details.cshtml
        │   │   ├── Edit.cshtml
        │   │   ├── Index.cshtml
        │   │   └── ManageEnrollments.cshtml
        │   ├── Courses
        │   │   ├── Create.cshtml
        │   │   ├── Delete.cshtml
        │   │   ├── Details.cshtml
        │   │   ├── Edit.cshtml
        │   │   └── Index.cshtml
        │   ├── Home
        │   │   ├── About.cshtml
        │   │   ├── Index.cshtml
        │   │   └── Privacy.cshtml
        │   ├── Lecturers
        │   │   ├── Create.cshtml
        │   │   ├── Delete.cshtml
        │   │   ├── Details.cshtml
        │   │   ├── Edit.cshtml
        │   │   └── Index.cshtml
        │   ├── Shared 
        │   │   ├── _Layout.cshtml
        │   │   ├── _Layout.cshtml.css
        │   │   ├── _LoginPartial.cshtml
        │   │   ├── _ValidationScriptsPartial.cshtml
        │   │   └── Error.cshtml
        │   ├── Students
        │   │   ├── Create.cshtml
        │   │   ├── Delete.cshtml
        │   │   ├── Details.cshtml
        │   │   ├── Edit.cshtml
        │   │   └── Index.cshtml
        │   ├── _ViewImports.cshtml
        │   └── _ViewStart.cshtml
        ├── wwwroot                                     (Asset, media, and library files)
        │   ├── css
        │   ├── images
        │   ├── js
        │   ├── lib
        │   └── favicon.ico
        ├── .gitignore
        ├── appsettings.Development.json
        ├── appsettings.json
        ├── note.txt
        ├── Program.cs
        ├── README.md
        ├── SchoolManagementApp.MVC.csproj
        └── SchoolManagementApp.MVC.sln

## How to install and run
To be updated

