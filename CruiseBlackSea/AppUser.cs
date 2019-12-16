namespace CruiseBlackSea
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppUser")]
    public partial class AppUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_user { get; set; }

        [StringLength(255)]
        public string last_name { get; set; }

        [StringLength(255)]
        public string first_name { get; set; }

        [StringLength(1000)]
        public string address_user { get; set; }

        [StringLength(255)]
        public string email_address { get; set; }

        [StringLength(14)]
        public string phone_number { get; set; }

        [StringLength(100)]
        public string password_user { get; set; }

        public byte? grant_user { get; set; }

        [Required]
        [StringLength(100)]
        public string user_name_app { get; set; }
    }
}
