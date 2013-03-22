namespace DigifySalesMVC.Web.Controllers
{
    using System;
    using System.Web.Mvc;

    public class ExperienceController : Controller
    {
        /// <summary>
        /// The index page is a list of all professional experience.
        /// </summary>
        /// <returns>
        /// The business experience view.
        /// </returns>
        public ActionResult Index()
        {
            return this.View();
        }
    }
}