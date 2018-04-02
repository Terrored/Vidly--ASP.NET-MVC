namespace VidlyV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUser2 : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4209755d-8eb6-46da-805a-77cbd7072fa2', N'DUPA@DUPA.com', 0, N'AOWBhJf81D5fVRE6BKWUGZQ0vgYTlNNCOS8TGyGm7sqbKQbMs3AAatYJtuNvcfWhFw==', N'59f3605e-2ff2-4bd7-91d1-fd1a29e18cb0', NULL, 0, 0, NULL, 1, 0, N'DUPA@DUPA.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'490123ee-5f69-49fd-ad69-d0c5b0b235bd', N'123@dupa.com', 0, N'ADI17VlnWS3VZmvG9LrmEej8dkru7Ex3yE6gDXAZzXPs/Y2V+xYSGrL0frVwqiGbnw==', N'ba6baa87-2f2f-499c-b0b3-79820436a5ce', NULL, 0, 0, NULL, 1, 0, N'123@dupa.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7f125e81-fe5e-4d16-a8a9-167c16c5b32b', N'admin1@vidly.com', 0, N'AN9pl/lxvvEMhlLLGzjOk2WssraHZCpOhO7E3VHaR9rwWUeyh+w4qaPjRzQb7l9iTg==', N'709e0601-11ff-4e5e-9b1f-eb061f59e813', NULL, 0, 0, NULL, 1, 0, N'admin1@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9c47166f-ef94-485a-a6c7-36185c010fad', N'adminnew@vidly.com', 0, N'AE2HvIM3Vuyo6oluHCnsx0ta/HSKo4eXVUuGe88MakbF3DhOQzs44PBW0BgTulIvRQ==', N'b79559d2-47bf-420c-a972-14c37b9cbc3f', NULL, 0, 0, NULL, 1, 0, N'adminnew@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f3eeb89a-8f31-4e84-b838-c1f0b09cd149', N'admin@vidly.com', 0, N'AG175MLEFX5jg8EZ3DD/mDX8LdPqnmmQJF0wLknxK/tP5BzIM+Ovr/RMcaX89nmazA==', N'6c579f24-4d4d-4c8c-8c9a-059ede9cc803', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fd96f697-1590-4653-818d-a37b325f857a', N'guest@vidly.com', 0, N'AGohZPOse3KZULqod7PNk4jgqxNSilpci6wfeKthZPd3f1OIcoOJachSgrK/F8gZUA==', N'a31126ec-dacd-48f6-afff-f0923ab67f79', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2d1fdb86-1ec1-435e-856a-7069cb630a9f', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4209755d-8eb6-46da-805a-77cbd7072fa2', N'2d1fdb86-1ec1-435e-856a-7069cb630a9f')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9c47166f-ef94-485a-a6c7-36185c010fad', N'2d1fdb86-1ec1-435e-856a-7069cb630a9f')

                    ");
        }
        
        public override void Down()
        {
        }
    }
}
