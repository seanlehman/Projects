using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElevenNote.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace ElevenNote.Web 
{
    public class CommonController : Controller
    {
        #region Properties

        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;


        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            protected set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            protected set
            {
                _userManager = value;
            }
        }

        /// <summary>
        /// Retrieves the currently logged in User ID, likely populated by the Bearer token when authenticating.
        /// </summary>
        protected Guid AuthUserId
        {
            get
            {
                return new Guid(User.Identity.GetUserId());

            }
        }

        #endregion

    }
}