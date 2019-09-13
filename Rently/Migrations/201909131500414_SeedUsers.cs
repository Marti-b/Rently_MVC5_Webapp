namespace Rently.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
               INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'24bdf8d9-6073-43a6-83d9-5e0305424e46', N'guest@rently.com', 0, N'APIEMx1a4l29/RJPxiQLjGUBGP9idoGeWK+Aq38IW53TQ80wJx7BJT+BdRbOHxYaxQ==', N'155080a2-fef3-4f83-9e30-a1da957462e4', NULL, 0, 0, NULL, 1, 0, N'guest@rently.com')
               INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b2354abf-00a3-4812-9de5-c4d2c6e8932a', N'admin@rently.com', 0, N'ABhcUoqd7Rxyb9p6byyN8rzA9EtjtJIUc5r8x+6byn9jVJFE3D5WQClrrUtzwrx54Q==', N'5cb3d3d0-9b67-45cf-a1a2-1c6b70020c9e', NULL, 0, 0, NULL, 1, 0, N'admin@rently.com')


               INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'58d1d02f-ce22-4702-847b-f15276d74aa6', N'Admin')
               INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b2354abf-00a3-4812-9de5-c4d2c6e8932a', N'58d1d02f-ce22-4702-847b-f15276d74aa6')


        ");
        }

        public override void Down()
        {
        }
    }
}
