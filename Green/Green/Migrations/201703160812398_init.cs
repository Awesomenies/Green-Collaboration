namespace Green.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImagesUrl = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
          
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Utilities", "UtilitieCategoryId", "dbo.UtilitieCategories");
            DropForeignKey("dbo.Tips", "TipCategori_Id", "dbo.TipCategoris");
            DropForeignKey("dbo.Texts", "Place_Id", "dbo.Places");
            DropForeignKey("dbo.Ads", "AdsCategori_Id", "dbo.AdsCategoris");
            DropIndex("dbo.Utilities", new[] { "UtilitieCategoryId" });
            DropIndex("dbo.Tips", new[] { "TipCategori_Id" });
            DropIndex("dbo.Texts", new[] { "Place_Id" });
            DropIndex("dbo.Ads", new[] { "AdsCategori_Id" });
            DropTable("dbo.Utilities");
            DropTable("dbo.UtilitieCategories");
            DropTable("dbo.UserAccounts");
            DropTable("dbo.Tips");
            DropTable("dbo.TipCategoris");
            DropTable("dbo.Texts");
            DropTable("dbo.Sliders");
            DropTable("dbo.Places");
            DropTable("dbo.NewsTexts");
            DropTable("dbo.NewsSliders");
            DropTable("dbo.NewsSliderNationalts");
            DropTable("dbo.NewsSliderLokalts");
            DropTable("dbo.NewsSliderIneternationalts");
            DropTable("dbo.News");
            DropTable("dbo.NewsLikes");
            DropTable("dbo.NewsLetters");
            DropTable("dbo.NewsComments");
            DropTable("dbo.ContactTexts");
            DropTable("dbo.ContactSliders");
            DropTable("dbo.Contacts");
            DropTable("dbo.BlogTexts");
            DropTable("dbo.BlogSliders");
            DropTable("dbo.Blogs");
            DropTable("dbo.BlogLikes");
            DropTable("dbo.BlogComments");
            DropTable("dbo.Ads");
            DropTable("dbo.AdsCategoris");
        }
    }
}
