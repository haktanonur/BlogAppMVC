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
                        new User { UserName = "onurhaktan"},
                        new User { UserName = "goksuturac"}
                    );
                    context.SaveChanges();
                }

                if(!context.Posts.Any())
                {
                    context.Posts.AddRange(
                        new Post {
                            Title = "ASP.NET Core",
                            Content = "Asp.net core course",
                            Url = "aspnet-core",
                            IsActive = true,
                            Image = "3.jpg",
                            PublishedOn = DateTime.Now.AddDays(-10),
                            Tags = context.Tags.Take(3).ToList(),
                            UserId = 1,
                            Comments = new List<Comment> { 
                                new Comment { Text = "Good course", PublishedOn = DateTime.Now.AddDays(-20), UserId = 1},
                                new Comment { Text = "That's a very useful course", PublishedOn = DateTime.Now.AddDays(-10), UserId = 2},
                            }
                        },
                        new Post {
                            Title = "Php",
                            Content = "Php course",
                            Url = "php",
                            IsActive = true,
                            Image = "1.jpg",
                            PublishedOn = DateTime.Now.AddDays(-20),
                            Tags = context.Tags.Take(2).ToList(),
                            UserId = 1
                        },
                        new Post {
                            Title = "Django",
                            Content = "Django cours",
                             Url = "django",
                            IsActive = true,
                            Image = "2.jpg",
                            PublishedOn = DateTime.Now.AddDays(-30),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 2
                        }
                        ,
                        new Post {
                            Title = "ReactJS",
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