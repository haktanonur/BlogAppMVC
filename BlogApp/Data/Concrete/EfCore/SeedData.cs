using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void FillTestData(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();

            if(context != null)
            {
                if(context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }

                if(!context.Tags.Any())
                {
                    context.Tags.AddRange(
                        new Tag { Text = "web programlama", Url = "web-programlama", Color=TagColors.warning},
                        new Tag { Text = "backend", Url = "backend", Color=TagColors.primary},
                        new Tag { Text = "frontend", Url = "frontend", Color=TagColors.success},
                        new Tag { Text = "fullstack", Url = "fullstack", Color=TagColors.secondary},
                        new Tag { Text = "php", Url = "php", Color=TagColors.danger}
                    );
                    context.SaveChanges();
                }

                if(!context.Users.Any())
                {
                    context.Users.AddRange(
                        new User { UserName = "onurhaktan", Name = "Onur Haktan", Email = "onur@gmail.com", Password = "12345", Image = "p1.jpg"},
                        new User { UserName = "goksuturac", Name = "Göksu Turaç", Email = "goksu@gmail.com", Password = "12345", Image = "p2.jpg"}
                    );
                    context.SaveChanges();
                }

                if(!context.Posts.Any())
                {
                    context.Posts.AddRange(
                        new Post {
                            Title = "ASP.NET Core",
                            Description = "Build web APIs and web UI using ASP.NET Core MVC",
                            Content = "ASP.NET Core MVC provides features to build web APIs and web apps: The Model-View-Controller (MVC) pattern helps make your web APIs and web apps testable. Razor Pages is a page-based programming model that makes building web UI easier and more productive. Razor markup provides a productive syntax for Razor Pages and MVC views. Tag Helpers enable server-side code to participate in creating and rendering HTML elements in Razor files. Built-in support for multiple data formats and content negotiation lets your web APIs reach a broad range of clients, including browsers and mobile devices. Model binding automatically maps data from HTTP requests to action method parameters. Model validation automatically performs client-side and server-side validation.",
                            Url = "aspnet-core",
                            IsActive = true,
                            Image = "aspnetcore.png",
                            PublishedOn = DateTime.Now.AddDays(-10),
                            Tags = context.Tags.Take(3).ToList(),
                            UserId = 1,
                            Comments = new List<Comment> { 
                                new Comment { Text = "Good course", PublishedOn = DateTime.Now.AddDays(-20), UserId = 1},
                                new Comment { Text = "That's a very useful course", PublishedOn = DateTime.Now.AddDays(-10), UserId = 2},
                            }
                        },
                        new Post {
                            Title = "Spring Framework",
                            Description = "Spring makes Java modern.",
                            Content = "The Spring Framework is an application framework and inversion of control container for the Java platform.[2] The framework's core features can be used by any Java application, but there are extensions for building web applications on top of the Java EE (Enterprise Edition) platform. The framework does not impose any specific programming model.[citation needed]. The framework has become popular in the Java community as an addition to the Enterprise JavaBeans (EJB) model.[3] The Spring Framework is free and open source software.",
                            Url = "spring",
                            IsActive = true,
                            Image = "spring.png",
                            PublishedOn = DateTime.Now.AddDays(-20),
                            Tags = context.Tags.Take(2).ToList(),
                            UserId = 1
                        },
                        new Post {
                            Title = "Django",
                            Description = "Django makes it easier to build better web apps more quickly and with less code.",
                            Content = "Django is a high-level Python web framework that encourages rapid development and clean, pragmatic design. Built by experienced developers, it takes care of much of the hassle of web development, so you can focus on writing your app without needing to reinvent the wheel. It’s free and open source.",
                            Url = "django",
                            IsActive = true,
                            Image = "django.png",
                            PublishedOn = DateTime.Now.AddDays(-30),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 2
                        }
                        ,
                        new Post {
                            Title = "ReactJS",
                            Description = "React course",
                            Content = "React course",
                            Url = "react",
                            IsActive = true,
                            Image = "3.jpg",
                            PublishedOn = DateTime.Now.AddDays(-40),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 2
                        }
                        ,
                        new Post {
                            Title = "AngularJS",
                            Description = "Angular course",
                            Content = "Angular course",
                            Url = "angular",
                            IsActive = true,
                            Image = "1.jpg",
                            PublishedOn = DateTime.Now.AddDays(-50),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 2
                        }
                        ,
                        new Post {
                            Title = "Web Design",
                            Description = "Web Design",
                            Content = "Web design course",
                            Url = "web-design",
                            IsActive = true,
                            Image = "2.jpg",
                            PublishedOn = DateTime.Now.AddDays(-60),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 2
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}