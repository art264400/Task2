using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;
using System.Linq;

namespace EF.DataBase.Migrations
{
    public partial class AddStoredSec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var resourceNames = this.GetType().Assembly.GetManifestResourceNames();

            var sqlScripst = new[]
          {
                "get_timeslots.sql"
            };
            foreach (var sqlScriptName in sqlScripst)
            {
                var sqlResourceName = resourceNames.SingleOrDefault(r => r.Contains(sqlScriptName));
                using var stream = this.GetType().Assembly.GetManifestResourceStream(sqlResourceName);
                using var reader = new StreamReader(stream!);
                var sql = reader.ReadToEnd(); ;
                migrationBuilder.Sql(sql);
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
