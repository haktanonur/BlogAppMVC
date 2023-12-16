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
- Users have a profile page.
- Profile page displays the user's posts and comments.
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

![Screenshot 2023-12-17 015515](https://github.com/haktanonur/aspnetcore-mvc-blog-app/assets/69698425/c6472e73-5546-4ae8-bdc6-cab82dd5234a)
![Screenshot 2023-12-17 015454](https://github.com/haktanonur/aspnetcore-mvc-blog-app/assets/69698425/f0e92d6f-4fcf-4038-b060-b7587579f0b5)
![Screenshot 2023-12-17 015440](https://github.com/haktanonur/aspnetcore-mvc-blog-app/assets/69698425/2ba5dad9-3753-427e-a800-8477aee232d9)
![Screenshot 2023-12-17 015428](https://github.com/haktanonur/aspnetcore-mvc-blog-app/assets/69698425/e65c57a6-cf12-4ef7-85e9-a09604943c01)
![Screenshot 2023-12-17 015413](https://github.com/haktanonur/aspnetcore-mvc-blog-app/assets/69698425/935c0ea9-0d9d-425f-8798-7e9eabbc1c7b)
![Screenshot 2023-12-17 015348](https://github.com/haktanonur/aspnetcore-mvc-blog-app/assets/69698425/8e84f785-6e13-40c5-b072-f6a17cf08ae2)
![Screenshot 2023-12-17 015328](https://github.com/haktanonur/aspnetcore-mvc-blog-app/assets/69698425/075282fc-b864-4c11-a5ba-a8490e126cbc)
![Screenshot 2023-12-17 015318](https://github.com/haktanonur/aspnetcore-mvc-blog-app/assets/69698425/8bdb6e97-9b12-4738-8bae-e8886856565c)

