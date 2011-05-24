using System.Web.Mvc;
using DigifySalesMVC.Web.Controllers;
using NUnit.Framework;

namespace DigifySalesMVC.Web.Test.Controllers
{
    [TestFixture]
    public class TermsControllerTest
    {
        [Test]
        public void TermsController_IndexAction_ReturnsView()
        {
            var controller = new TermsController();

            ActionResult result = controller.Index();

            Assert.IsInstanceOf<ViewResult>(result);
        }
    }
}