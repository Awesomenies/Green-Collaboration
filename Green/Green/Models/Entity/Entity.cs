using Green.Models.Entity.Beregner;
using Green.Models.User;
using System.Web.Mvc;

namespace Green.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Entity : DbContext
    {
        // Your context has been configured to use a 'Entity' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Green.Models.Entity.Entity' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Entity' 
        // connection string in the application configuration file.
        public Entity()
            : base("name=Entity")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<Tip> Tips { get; set; }
        public virtual DbSet<Text> Texts { get; set; }
        public virtual DbSet<TipCategori> TipCategoris { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<AdsCategori> AdsCategoris { get; set; }
        public virtual DbSet<Utilitie> Utilities { get; set; }
        public virtual DbSet<UtilitieCategory> UtilitieCategories { get; set; }
        public virtual DbSet<Ads> Adses { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }
        //Blog loaded here
        public virtual DbSet<Blog> Blogs{ get; set; }
        public virtual DbSet<BlogText> BlogTexts { get; set; }
        public virtual DbSet<BlogSlider> BlogSliders { get; set; }
        public virtual DbSet<BlogComment>BlogComments { get; set; }
        public virtual DbSet<BlogLike>BlogLikes { get; set; }
        //News loaded here
        public virtual DbSet<News> Newss { get; set; }
        public virtual DbSet<NewsText> NewsTexts { get; set; }
        public virtual DbSet<NewsSlider> NewsSliders { get; set; }
        public virtual DbSet<NewsSliderIneternationalt> NewsSliderIneternationalts { get; set; }
        public virtual DbSet<NewsSliderLokalt> NewsSliderLokalts { get; set; }
        public virtual DbSet<NewsSliderNationalt> NewsSliderNationalts { get; set; }
        public virtual DbSet<NewsComment> NewsComments { get; set; }
        public virtual DbSet<NewsLike> NewsLikes { get; set; }
        //Contact loaded here
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContactText> ContactTexts { get; set; }
        public virtual DbSet<ContactSlider> ContactSliders { get; set; }
        public virtual DbSet<NewsLetter> NewsLetters { get; set; }
        //public virtual DbSet<> MyProperty { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}