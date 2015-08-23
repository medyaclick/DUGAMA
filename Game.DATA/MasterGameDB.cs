namespace Game.DATA
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MasterGameDB : DbContext
    {
        private static MasterGameDB _masterGame;
        private static Object kanalKontrol = new Object();

        private MasterGameDB()
            : base("name=MasterGameDB")
        {

        }

        public static MasterGameDB Initilize()//Singleton design pattern
        {
            if (_masterGame == null)
                lock (kanalKontrol)
                {
                    if (_masterGame == null)
                        _masterGame = new MasterGameDB();
                }
            return _masterGame;
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<Games_Categories> Games_Categories { get; set; }
        public virtual DbSet<Games_Impressions> Games_Impressions { get; set; }
        public virtual DbSet<Games_Points> Games_Points { get; set; }
        public virtual DbSet<Search_Engine_Optimization> Search_Engine_Optimization { get; set; }
        public virtual DbSet<System_Roles> System_Roles { get; set; }
        public virtual DbSet<System_Users> System_Users { get; set; }
        public virtual DbSet<System_Users_Roles> System_Users_Roles { get; set; }
        public virtual DbSet<Web_Sites> Web_Sites { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Categories>()
                .Property(e => e.Icon_Path)
                .IsUnicode(false);

            modelBuilder.Entity<Games>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Games>()
                .Property(e => e.Name_Url)
                .IsUnicode(false);

            modelBuilder.Entity<Games>()
                .Property(e => e.Game_File_Path)
                .IsUnicode(false);

            modelBuilder.Entity<Games>()
                .Property(e => e.Game_Main_Image_Path)
                .IsUnicode(false);

            modelBuilder.Entity<Games>()
                .Property(e => e.Labels)
                .IsUnicode(false);

            modelBuilder.Entity<Games_Impressions>()
                .Property(e => e.Cookie_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Games_Points>()
                .Property(e => e.Cookie_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Search_Engine_Optimization>()
                .Property(e => e.SEO_Desctiption)
                .IsUnicode(false);

            modelBuilder.Entity<Search_Engine_Optimization>()
                .Property(e => e.SEO_Keywords)
                .IsUnicode(false);

            modelBuilder.Entity<Search_Engine_Optimization>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<System_Roles>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<System_Users>()
                .Property(e => e.User_Name)
                .IsUnicode(false);

            modelBuilder.Entity<System_Users>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<System_Users>()
                .Property(e => e.Name_Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Sites>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Sites>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Sites>()
                .Property(e => e.Facebook_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Sites>()
                .Property(e => e.Twitter_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Web_Sites>()
                .Property(e => e.Favicon_Path)
                .IsUnicode(false);
        }
    }
}
