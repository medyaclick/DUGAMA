namespace Game.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Categories
    {
        public short id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public short Top_Category_Id { get; set; }

        public byte Site_Id { get; set; }

        [StringLength(100)]
        public string Icon_Path { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Datetime { get; set; }
    }
}
