using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCodeFirstSqlVs.Migrations
{
    public partial class DemoData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [UniqueClasses] (Id, Name) VALUES ('47FDFB02-BE15-4FB3-93AA-05C7769CB811', 'My Value 1')");
            migrationBuilder.Sql("INSERT INTO [UniqueClasses] (Id, Name) VALUES ('A237E39B-BE30-4DD3-8C26-7DFFC6565AA9', 'My Value 2')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
