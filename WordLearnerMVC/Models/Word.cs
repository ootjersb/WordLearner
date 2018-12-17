namespace WordLearnerMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Word
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Word()
        {
            Translations = new HashSet<Translation>();
            Practices = new HashSet<PracticeRecord>();
        }

        public int WordID { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Display(Name ="WordType")]
        public int WordTypeID { get; set; }

        [Required]
        [StringLength(3)]
        [Display(Name="Language")]
        public string LanguageID { get; set; }

        public virtual Language Language { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Translation> Translations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PracticeRecord> Practices { get; set; }

        [Display(Name ="Word Type")]
        public virtual WordType WordType { get; set; }
    }
}
