namespace Game.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class System_Users
    {
        public short id { get; set; }

        [Required]
        [StringLength(50)]
        public string User_Name { get; set; }

        [Required]
        [StringLength(500)]
        public string Password { get; set; }

        [Required]
        [StringLength(150)]
        public string Name_Surname { get; set; }

        public byte Site_Id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Datetime { get; set; }
    }
}
