namespace WordLearnerMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Practices = new HashSet<PracticeRecord>();
        }

        [StringLength(50)]
        public string Name { get; set; }

        public int UserID { get; set; }

        [StringLength(3)]
        public string DefSourceLanguageID { get; set; }

        [StringLength(3)]
        public string DefDestinationLanguageID { get; set; }

        public virtual Language Language { get; set; }

        public virtual Language Language1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PracticeRecord> Practices { get; set; }
    }
}
