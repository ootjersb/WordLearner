using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordLearnerMVC.Models
{
    public class Practice
    {
        public virtual Word Word { get; set; }

        public List<Word> Choices { get; set; }
    }
}