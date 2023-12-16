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

![Screenshot 2023-12-17 015515](https://github.com/haktanonur/aspnetcore-mvc-blog-app/assets/69698425/f3cebf58-2553-4cb3-acfc-28f6c785c1ea)
![Screenshot 2023-12-17 015454](https://github.com/haktanonur/aspnetcore-mvc-blog-app/assets/69698425/e8c625aa-9c7f-4b3f-bfc4-33831e71f37f)
![Screenshot 2023-12-17 015440](https://github.com/haktanonur/aspnetcore-mvc-blog-app/assets/69698425/889ec3ac-95b6-4c13-9eb0-77f9e9e6d5b5)
![Screenshot 2023-12-17 015428](https://github.com/haktanonur/aspnetcore-mvc-blog-app/assets/69698425/9fd9606c-c646-46a8-9e8c-1f349b327b1e)
![Screenshot 2023-12-17 015413](https://github.com/haktanonur/aspnetcore-mvc-blog-app/assets/69698425/e67aaa7d-d09b-41bb-b549-8e54f50fdaa2)
![Screenshot 2023-12-17 015348](https://github.com/haktanonur/aspnetcore-mvc-blog-app/assets/69698425/9e4ad0dc-75c5-46ee-8774-466002a4779c)
![Screenshot 2023-12-17 015328](https://github.com/haktanonur/aspnetcore-mvc-blog-app/assets/69698425/2be4556b-d39c-4c40-af55-04e7d7c9fdef)
![Screenshot 2023-12-17 015318](https://github.com/haktanonur/aspnetcore-mvc-blog-app/assets/69698425/cdb65e76-34c9-4f6a-ac2d-797a080e1d9d)
