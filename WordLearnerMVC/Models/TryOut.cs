using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WordLearnerMVC.Models
{
    public class TryOut
    {
        [DataType(DataType.Date)]
        public DateTime BusinessDate { get; set; }
    }
}