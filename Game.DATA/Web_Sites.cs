namespace Game.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Web_Sites
    {
        public short id { get; set; }

        [Required]
        [StringLength(100)]
        public string Url { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(100)]
        public string Facebook_Id { get; set; }

        [StringLength(100)]
        public string Twitter_Id { get; set; }

        [StringLength(100)]
        public string Favicon_Path { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Datetime { get; set; }
    }
}
