using System.Web.Mvc;
using DigifySalesMVC.Web.Controllers;
using NUnit.Framework;

namespace DigifySalesMVC.Web.Test.Controllers
{
    [TestFixture]
    public class PrivacyControllerTest
    {
        [Test]
        public void PrivacyController_IndexAction_ReturnsView()
        {
            var controller = new PrivacyController();

            ActionResult result = controller.Index();

            Assert.IsInstanceOf<ViewResult>(result);
        }
    }
}