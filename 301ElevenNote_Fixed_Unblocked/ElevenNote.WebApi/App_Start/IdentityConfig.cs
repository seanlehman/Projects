using System.Threading.Tasks;
using ElevenNote.Data;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using ElevenNote.WebApi.Models;

namespace ElevenNote.WebApi
{
    // Configure the application user manager used in this application. UserManager is defined in ASP.NET Identity and is used by the application.

    public class ElevenNoteUserManager : UserManager<ElevenNoteUser>
    {
        public ElevenNoteUserManager(IUserStore<ElevenNoteUser> store)
            : base(store)
        {
        }

        public static ElevenNoteUserManager Create(IdentityFactoryOptions<ElevenNoteUserManager> options, IOwinContext context)
        {
            var manager = new ElevenNoteUserManager(new UserStore<ElevenNoteUser>(context.Get<ElevenNoteDbContext>()));
            // Configure validation logic for usernames
            manager.UserValidator = new UserValidator<ElevenNoteUser>(manager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };
            // Configure validation logic for passwords
            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit = true,
                RequireDigit = true,
                RequireLowercase = true,
                RequireUppercase = true,
            };
            var dataProtectionProvider = options.DataProtectionProvider;
            if (dataProtectionProvider != null)
            {
                manager.UserTokenProvider = new DataProtectorTokenProvider<ElevenNoteUser>(dataProtectionProvider.Create("ASP.NET Identity"));
            }
            return manager;
        }
    }
}