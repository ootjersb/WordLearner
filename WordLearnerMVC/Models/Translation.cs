namespace WordLearnerMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Translation
    {
        [Required]
        [StringLength(256)]
        public string Meaning { get; set; }

        [Required]
        [StringLength(3)]
        public string LanguageTranslation { get; set; }

        public int WordID { get; set; }

        public int TranslationID { get; set; }

        public virtual Language Language { get; set; }

        public virtual Word Word { get; set; }
    }
}
