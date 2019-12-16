namespace CruiseBlackSea
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cruise")]
    public partial class Cruise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_cruise { get; set; }

        public int? type_cruise { get; set; }

        [StringLength(30)]
        public string harbour_list { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_start { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_end { get; set; }

        public float? price { get; set; }

        public int? number_passengers { get; set; }
    }
}
