using System.Web.Mvc;
using DigifySalesMVC.Web.Controllers;
using NUnit.Framework;

namespace DigifySalesMVC.Web.Test.Controllers
{
    [TestFixture]
    public class SupportControllerTest
    {
        [Test]
        public void SupportController_IndexAction_ReturnsView()
        {
            var controller = new SupportController();

            ActionResult result = controller.Index();

            Assert.IsInstanceOf<ViewResult>(result);
        }
    }
}