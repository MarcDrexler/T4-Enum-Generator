using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCodeFirstSqlliteVsCode.Migrations
{
    public partial class DemoData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Simple, just one word
            migrationBuilder.Sql("INSERT INTO [Parents] (Name, Discriminator) VALUES ('Parent1', 'Parent')");
            // Two Words
            migrationBuilder.Sql("INSERT INTO [Parents] (Name, Discriminator) VALUES ('Parent Two', 'Parent')");
            // Two Words with trailing number
            migrationBuilder.Sql("INSERT INTO [Parents] (Name, Discriminator) VALUES ('Parent 3', 'Parent')");
            // One word leading number
            migrationBuilder.Sql("INSERT INTO [Parents] (Name, Discriminator) VALUES ('4Parent', 'Parent')");
            // Two words leading number
            migrationBuilder.Sql("INSERT INTO [Parents] (Name, Discriminator) VALUES ('5 Parent', 'Parent')");
            // Special character
            migrationBuilder.Sql("INSERT INTO [Parents] (Name, Discriminator) VALUES ('Parent6Specialß', 'Parent')");
            // Special character two words
            migrationBuilder.Sql("INSERT INTO [Parents] (Name, Discriminator) VALUES ('Parent7Special ß', 'Parent')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
