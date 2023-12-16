# Asp.NET Core Mvc Blog App
The Blog Application, ASP.NET Core MVC, MySQL and Entity Framework uses are an improved application.

## Features
- User can register to the application. 
- User can log in to the application.(Authentication)
- User can view shared posts.
- User can create a new post.
- User can edit their own posts.
- User can delete their own posts.
- User can comment on a post. (jQuery - AJAX Methods are used.)
- Posts can be filtered by tags.
- There is an Admin role in the application. (Authorization)
- Admin can perform all actions that users can. 
- Admin can edit posts created by users.
- Admin can delete posts created by users.
- Posts created by users will not be active until approved by the admin.

## Tools and Technologies used in this project:
- .NET 8.0
- Entity Framework
- jQuery
- MySQL
- Visual Studio Code

## Getting Started

To get started with this project, you will need to have the following installed on your local machine:

- .NET 8 SDK
- MySQL 

#### To build and run the project, follow these steps:

- ```bash
    git clone https://github.com/haktanonur/aspnetcore-mvc-blog-app.git
    cd BlogApp
    ```

- Create a MySQL database and update the connection information in the `appsettings.json` file.

- Open the `appsettings.json` file and update your MySQL database connection information:
```json
    {
      "ConnectionStrings": {
"mysql_connection":"server=localhost;port=3306;database=database_name;user=username;password=password"
  }
    }
```

- To download bootstrap files:
 ```bash
    cd BlogApp/wwwroot/lib libman restore
 ```

- To create migrations:
```bash
    dotnet ef migrations add InitialCreate
    dotnet ef database update
```

- To run project:
```bash
    dotnet restore
    dotnet run
```