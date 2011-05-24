using System.Web.Mvc;
using DigifySalesMVC.Web.Controllers;
using NUnit.Framework;

namespace DigifySalesMVC.Web.Test.Controllers
{
    [TestFixture]
    public class AboutControllerTest
    {
        [Test]
        public void AboutController_IndexAction_ReturnsView()
        {
            var controller = new AboutController();

            ActionResult result = controller.Index();

            Assert.IsInstanceOf<ViewResult>(result);
        }
    }
}