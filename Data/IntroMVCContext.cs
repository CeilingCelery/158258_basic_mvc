using System.Data.Entity;

namespace IntroMVC.Data
{
    public class IntroMVCContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public IntroMVCContext() : base("name=IntroMVCContext")
        {
        }

        public System.Data.Entity.DbSet<IntroMVC.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<IntroMVC.Models.Category> Categories { get; set; }
    }
}
