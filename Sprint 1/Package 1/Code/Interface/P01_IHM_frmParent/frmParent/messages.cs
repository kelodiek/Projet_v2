namespace frmParent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class messages
    {
        [Key]
        [StringLength(50)]
        public string message_id { get; set; }

        public int? addresser { get; set; }

        [StringLength(50)]
        public string receiver { get; set; }

        [StringLength(50)]
        public string sets_id { get; set; }

        [StringLength(250)]
        public string message { get; set; }

        [StringLength(50)]
        public string state { get; set; }

        public virtual sets sets { get; set; }

        public virtual users users { get; set; }
    }
}
