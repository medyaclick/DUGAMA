namespace Game.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Games_Points
    {
        public long id { get; set; }

        public int Game_Id { get; set; }

        public byte Is_Like { get; set; }

        [Required]
        [StringLength(100)]
        public string Cookie_Id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Datetime { get; set; }
    }
}
