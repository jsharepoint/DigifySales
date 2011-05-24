using System.Web.Mvc;
using DigifySalesMVC.Web.Controllers;
using NUnit.Framework;

namespace DigifySalesMVC.Web.Test.Controllers
{
    [TestFixture]
    public class ProductsAndServicesTest
    {
        [Test]
        public void ProductsAndServicesController_IndexAction_ReturnsView()
        {
            var controller = new ProductsAndServicesController();

            ActionResult result = controller.Index();

            Assert.IsInstanceOf<ViewResult>(result);
        }
    }
}