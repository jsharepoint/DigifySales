using NUnit.Framework;
using DigifySalesMVC.Web.Controllers;
using System.Web.Mvc;

namespace DigifySalesMVC.Web.Test.Controllers
{
    [TestFixture]
    public class ExperienceControllerTest
    {
        [Test]
        public void Index_ReturnsView()
        {
            var experienceController = new ExperienceController();

            ActionResult result = experienceController.Index();

            Assert.IsInstanceOf<ViewResult>(result);
        }
    }
}
