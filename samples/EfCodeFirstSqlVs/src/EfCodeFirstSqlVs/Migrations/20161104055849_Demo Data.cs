using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCodeFirstSqlVs.Migrations
{
    public partial class DemoData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Simple, just one word
            migrationBuilder.Sql("INSERT INTO [dbo].[Parents] (Name, Discriminator) VALUES ('Parent1', 'Parent')");
            // Two Words
            migrationBuilder.Sql("INSERT INTO [dbo].[Parents] (Name, Discriminator) VALUES ('Parent Two', 'Parent')");
            // Two Words with trailing number
            migrationBuilder.Sql("INSERT INTO [dbo].[Parents] (Name, Discriminator) VALUES ('Parent 3', 'Parent')");
            // One word leading number
            migrationBuilder.Sql("INSERT INTO [dbo].[Parents] (Name, Discriminator) VALUES ('4Parent', 'Parent')");
            // Two words leading number
            migrationBuilder.Sql("INSERT INTO [dbo].[Parents] (Name, Discriminator) VALUES ('5 Parent', 'Parent')");
            // Special character
            migrationBuilder.Sql("INSERT INTO [dbo].[Parents] (Name, Discriminator) VALUES ('Parent6Specialß', 'Parent')");
            // Special character two words
            migrationBuilder.Sql("INSERT INTO [dbo].[Parents] (Name, Discriminator) VALUES ('Parent7Special ß', 'Parent')");

            // seed unique class sample
            migrationBuilder.Sql("INSERT INTO [dbo].[UniqueClasses] ([InternalId]) VALUES ('D646D22D-55E4-4357-986D-E75E6D744191')");
            migrationBuilder.Sql("INSERT INTO [dbo].[UniqueClasses] ([InternalId]) VALUES ('5C5C282C-DFCD-466C-BAFE-7CC6528F9170')");

            // seed language strings
            migrationBuilder.Sql("INSERT INTO [dbo].[LanguageStrings] ([Language], [Text], [UniqueClassId]) VALUES (1, N'German Name 1', 1)");
            migrationBuilder.Sql("INSERT INTO [dbo].[LanguageStrings] ([Language], [Text], [UniqueClassId]) VALUES (2, N'Englisch Name 1', 1)");
            migrationBuilder.Sql("INSERT INTO [dbo].[LanguageStrings] ([Language], [Text], [UniqueClassId]) VALUES (1, N'German Name 2', 2)");
            migrationBuilder.Sql("INSERT INTO [dbo].[LanguageStrings] ([Language], [Text], [UniqueClassId]) VALUES (2, N'Englisch Name 2', 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
