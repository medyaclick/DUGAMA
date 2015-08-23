namespace Game.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class System_Users_Roles
    {
        public int id { get; set; }

        public short User_Id { get; set; }

        public short Role_Id { get; set; }
    }
}
