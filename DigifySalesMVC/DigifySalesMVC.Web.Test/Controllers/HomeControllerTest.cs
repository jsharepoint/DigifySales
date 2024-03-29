﻿using NUnit.Framework;
using DigifySalesMVC.Web.Controllers;
using System.Web.Mvc;

namespace DigifySalesMVC.Web.Test.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void Index_ReturnsView()
        {
            var homeController = new HomeController();

            ActionResult result = homeController.Index();

            Assert.IsInstanceOf<ViewResult>(result);
        }
    }
}
