namespace frmParent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pieces
    {
        public pieces()
        {
            pieces_users = new HashSet<pieces_users>();
            sets_pieces = new HashSet<sets_pieces>();
        }

        [Key]
        [StringLength(50)]
        public string piece_id { get; set; }

        [StringLength(250)]
        public string descr { get; set; }

        [StringLength(250)]
        public string category { get; set; }

        public virtual ICollection<pieces_users> pieces_users { get; set; }

        public virtual ICollection<sets_pieces> sets_pieces { get; set; }
    }
}
