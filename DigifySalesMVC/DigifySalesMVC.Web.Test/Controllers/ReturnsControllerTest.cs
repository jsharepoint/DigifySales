using System.Web.Mvc;
using DigifySalesMVC.Web.Controllers;
using NUnit.Framework;

namespace DigifySalesMVC.Web.Test.Controllers
{
    [TestFixture]
    public class ReturnsControllerTest
    {
        [Test]
        public void ReturnsController_IndexAction_ReturnsView()
        {
            var controller = new ReturnsController();

            ActionResult result = controller.Index();

            Assert.IsInstanceOf<ViewResult>(result);
        }
    }
}