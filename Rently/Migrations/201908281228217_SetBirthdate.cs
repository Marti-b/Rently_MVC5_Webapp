using System.Web.UI.WebControls;

namespace Rently.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '1/1/1990' WHERE id = 1");
            Sql("UPDATE Customers SET Birthdate = '3/8/1986' WHERE id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
