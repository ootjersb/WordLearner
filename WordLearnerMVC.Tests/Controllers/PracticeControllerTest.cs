﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordLearnerMVC.Controllers;

namespace WordLearnerMVC.Tests.Controllers
{
    [TestClass]
    public class PracticeControllerTest
    {
        [TestMethod]
        public void Index_ShouldReturnWordAndChoices_OK()
        {
            PracticeController controller = new PracticeController();
            var result = controller.Index();
            result.ShouldNotBeNull();
        }
    }
}