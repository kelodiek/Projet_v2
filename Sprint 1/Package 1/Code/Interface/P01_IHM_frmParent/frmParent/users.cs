namespace frmParent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class users
    {
        public users()
        {
            messages = new HashSet<messages>();
            pieces_users = new HashSet<pieces_users>();
            sets_users = new HashSet<sets_users>();
        }

        [Key]
        public int user_id { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        [StringLength(50)]
        public string role { get; set; }

        [StringLength(250)]
        public string email { get; set; }

        public virtual ICollection<messages> messages { get; set; }

        public virtual ICollection<pieces_users> pieces_users { get; set; }

        public virtual ICollection<sets_users> sets_users { get; set; }
    }
}
