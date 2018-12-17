using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WordLearnerMVC.Controllers;
using WordLearnerMVC.Models;

namespace WordLearnerMVC.Tests.Controllers
{
    [TestClass]
    public class PracticeControllerTest
    {
        private readonly PracticeController controller = new PracticeController();

        [TestMethod]
        public void Index_CheckName_Empty()
        {
            var result = controller.Index() as ViewResult;
            result.ShouldNotBeNull();
            result.ViewName.ShouldBe("");
        }

        [TestMethod]
        public void Index_CheckModel_WordAnd4Choices()
        {
            var result = controller.Index() as ViewResult;
            var practice = result.ViewData.Model as Practice;
            practice.ShouldNotBeNull();
            practice.Word.ShouldNotBeNull();
            practice.Word.Description.ShouldNotBeNull();
            practice.Choices.Count.ShouldBe(4);
        }
    }
}
