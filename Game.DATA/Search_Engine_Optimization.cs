namespace Game.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Search_Engine_Optimization
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(160)]
        public string SEO_Desctiption { get; set; }

        [Required]
        [StringLength(1000)]
        public string SEO_Keywords { get; set; }

        [Required]
        [StringLength(10)]
        public string Type { get; set; }

        public int Interest_Id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Datetime { get; set; }
    }
}
