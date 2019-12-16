namespace CruiseBlackSea
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Harbour")]
    public partial class Harbour
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_harbour { get; set; }

        [StringLength(255)]
        public string harbour_name { get; set; }

        public int? position_x { get; set; }

        public int? position_y { get; set; }
    }
}
