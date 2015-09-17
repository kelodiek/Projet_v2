namespace frmParent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sets_pieces
    {
        [Required]
        [StringLength(50)]
        public string sets_id { get; set; }

        [Required]
        [StringLength(50)]
        public string piece_id { get; set; }

        public int num { get; set; }

        public int color { get; set; }

        public int type { get; set; }

        [Key]
        public int sets_piece_id { get; set; }

        public virtual colors colors { get; set; }

        public virtual pieces pieces { get; set; }

        public virtual sets sets { get; set; }
    }
}
