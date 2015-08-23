namespace Game.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Games_Categories
    {
        public int id { get; set; }

        public int Game_Id { get; set; }

        public short Category_Id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Datetime { get; set; }
    }
}
