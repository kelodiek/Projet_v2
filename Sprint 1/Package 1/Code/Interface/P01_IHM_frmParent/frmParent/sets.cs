namespace frmParent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sets
    {
        public sets()
        {
            messages = new HashSet<messages>();
            sets_users = new HashSet<sets_users>();
            sets_pieces = new HashSet<sets_pieces>();
        }

        [Key]
        [StringLength(50)]
        public string sets_id { get; set; }

        [StringLength(50)]
        public string year { get; set; }

        [StringLength(50)]
        public string pieces { get; set; }

        [StringLength(250)]
        public string t1 { get; set; }

        [StringLength(250)]
        public string descr { get; set; }

        public virtual ICollection<messages> messages { get; set; }

        public virtual ICollection<sets_users> sets_users { get; set; }

        public virtual ICollection<sets_pieces> sets_pieces { get; set; }
    }
}
