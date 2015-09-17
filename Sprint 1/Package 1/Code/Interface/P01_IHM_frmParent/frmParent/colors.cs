namespace frmParent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class colors
    {
        public colors()
        {
            sets_pieces = new HashSet<sets_pieces>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(250)]
        public string descr { get; set; }

        public virtual ICollection<sets_pieces> sets_pieces { get; set; }
    }
}
