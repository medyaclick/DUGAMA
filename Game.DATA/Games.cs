namespace Game.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Games
    {
        public int id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        public string Name_Url { get; set; }

        public short Site_Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Game_File_Path { get; set; }

        [Required]
        [StringLength(200)]
        public string Game_Main_Image_Path { get; set; }

        [Required]
        [StringLength(500)]
        public string Labels { get; set; }

        public bool State { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Datetime_Publish { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Datetime_Save { get; set; }
        public int Like_Count { get; set; }
        public int Unlike_Count { get; set; }
        public float Rate { get; set; }
    }
}
