using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LiteTe.Data
{
    public class SeedData
    {
        public static void Initialize (IServiceProvider serviceProvider)
        {
            using var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()
                
                );
            if(context==null || context.Cities ==null)
            {
                throw new NullReferenceException("");

            }
            if (context.Cities.Any())
            {
                return;
            }
            context.Cities.AddRange(

                new City
                {
                    CityName = "Чебоксары"
                },
                 new City
                 {
                     CityName = "Новочебоксарск"
                 },
                  new City
                  {
                      CityName = "Алатырь"
                  }

                );
            context.SaveChanges();
            var user1 = new ApplicationUser
            {
                UserName = "Testus@mail.ru",
                Email = "Testus@mail.ru",
                Surname = "Данилов",
                CityId = 1,
                NormalizedEmail = "TESTUS@MAIL.RU",
                NormalizedUserName = "TESTUS@MAIL.RU",
                LockoutEnabled=true
            };
            var user2 = new ApplicationUser
            {
                UserName = "Testus@gmail.com",
                Email = "Testus@gmail.com",
                Surname = "Иванов",
                CityId = 1,
                NormalizedEmail = "TESTUS@GMAIL.com",
                NormalizedUserName = "TESTUS@GMAIL.com",
                LockoutEnabled = true
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user1.PasswordHash = passwordHash.HashPassword(user1, "Testpass1234!");

            user2.PasswordHash = passwordHash.HashPassword(user1, "Testpass1234!");

            var role1 = new IdentityRole("Administrator");
            var role2 = new IdentityRole("User");

            context.Roles.Add(role1);
            context.Roles.Add(role2);
            context.Users.Add(user1);
            context.Users.Add(user2);
            context.SaveChanges();

            context.UserRoles.Add(
                new IdentityUserRole<string>
                {
                    RoleId = role1.Id,
                    UserId = user1.Id
                }
                );

            context.UserRoles.Add(
                new IdentityUserRole<string>
                {
                    RoleId = role2.Id,
                    UserId = user2.Id
                }
                );
            context.SaveChanges();


        }
    }
}
