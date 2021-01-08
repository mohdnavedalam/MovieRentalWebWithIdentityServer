namespace MovieRentalWithIdentity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0d88758e-fbdf-4299-a9b8-4d29081faaca', N'admin@movierental.com', 0, N'ALZMfPjgqNsL1sRd2LYR9CH1e3XNeQZ0g+x5qHadoITVvveLqh8TtgEcQRxIivhZqw==', N'd5f4d34d-7a0e-4293-b3b2-2dcb2a8b3d48', NULL, 0, 0, NULL, 1, 0, N'admin@movierental.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8f07c087-e4d6-475a-a4a4-8f7b2f4fb522', N'guest@movierental.com', 0, N'AMadN/dm7YiF4IX1PPUT0TltgD0D+VSc93Q9QzVFHCxqgchXIAa6U35I2X2wzETMzA==', N'329ca5c7-e10b-4a20-92ae-47421b98debf', NULL, 0, 0, NULL, 1, 0, N'guest@movierental.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bc0f11de-271c-47c6-9085-3bc02eab4dc0', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0d88758e-fbdf-4299-a9b8-4d29081faaca', N'bc0f11de-271c-47c6-9085-3bc02eab4dc0')
");
        }
        
        public override void Down()
        {
        }
    }
}
