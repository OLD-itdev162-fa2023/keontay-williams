using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Posts.Any())
            {
                var Posts = new List<Post>
                {
                    new Post {
                        Title = "First post",
                        Body = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque",
                        Date = DateTime.Now.AddDays(-10)
                    },
                    new Post {
                        Title = "Second post",
                        Body = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium",
                        Date = DateTime.Now.AddDays(-7)
                    },
                    new Post {
                        Title = "Third post",
                        Body = "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat",
                        Date = DateTime.Now.AddDays(-4)
                    }
                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}