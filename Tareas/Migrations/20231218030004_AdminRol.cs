using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tareas.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF NOT EXISTS(SELECT Id FROM AspNetRoles WHERE Id = '04f6d2b3-af67-483c-8a9e-d906969faf77')
                                    BEGIN
                                    INSERT AspNetRoles (Id, [Name], [NormalizedName])
                                    VALUES ('04f6d2b3-af67-483c-8a9e-d906969faf77','admin','ADMIN')
                                    END");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE AspNetRoles where Id = '04f6d2b3-af67-483c-8a9e-d906969faf77';");
        }
    }
}
