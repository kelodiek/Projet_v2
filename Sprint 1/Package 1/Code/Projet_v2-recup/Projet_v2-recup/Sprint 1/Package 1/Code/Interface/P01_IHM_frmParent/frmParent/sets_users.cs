namespace frmParent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sets_users
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string sets_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int user_id { get; set; }

        [StringLength(50)]
        public string state { get; set; }

        public virtual sets sets { get; set; }

        public virtual users users { get; set; }
    }
}
