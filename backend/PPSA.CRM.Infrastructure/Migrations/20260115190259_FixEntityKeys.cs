using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPSA.CRM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixEntityKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_activities_customers_customer_id",
                table: "activities");

            migrationBuilder.DropForeignKey(
                name: "FK_activities_projects_project_id",
                table: "activities");

            migrationBuilder.DropForeignKey(
                name: "FK_activities_users_assigned_to_user_id",
                table: "activities");

            migrationBuilder.DropForeignKey(
                name: "FK_contacts_customers_customer_id",
                table: "contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_customers_users_assigned_to_user_id",
                table: "customers");

            migrationBuilder.DropForeignKey(
                name: "FK_next_steps_customers_customer_id",
                table: "next_steps");

            migrationBuilder.DropForeignKey(
                name: "FK_next_steps_projects_project_id",
                table: "next_steps");

            migrationBuilder.DropForeignKey(
                name: "FK_next_steps_users_assigned_to_user_id",
                table: "next_steps");

            migrationBuilder.DropForeignKey(
                name: "FK_projects_customers_customer_id",
                table: "projects");

            migrationBuilder.DropForeignKey(
                name: "FK_projects_users_project_manager_user_id",
                table: "projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_projects",
                table: "projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_partners",
                table: "partners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_next_steps",
                table: "next_steps");

            migrationBuilder.DropIndex(
                name: "IX_next_steps_assigned_to_user_id",
                table: "next_steps");

            migrationBuilder.DropIndex(
                name: "IX_next_steps_customer_id",
                table: "next_steps");

            migrationBuilder.DropIndex(
                name: "IX_next_steps_project_id",
                table: "next_steps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customers",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_customers_assigned_to_user_id",
                table: "customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_contacts",
                table: "contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_activities",
                table: "activities");

            migrationBuilder.DropIndex(
                name: "IX_activities_assigned_to_user_id",
                table: "activities");

            migrationBuilder.DropIndex(
                name: "IX_activities_customer_id",
                table: "activities");

            migrationBuilder.DropIndex(
                name: "IX_activities_project_id",
                table: "activities");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "users");

            migrationBuilder.DropColumn(
                name: "project_id",
                table: "projects");

            migrationBuilder.DropColumn(
                name: "customer_id",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "contact_id",
                table: "contacts");

            migrationBuilder.RenameTable(
                name: "customers",
                newName: "Customers");

            migrationBuilder.RenameColumn(
                name: "last_login_date",
                table: "users",
                newName: "last_login");

            migrationBuilder.RenameColumn(
                name: "partner_id",
                table: "partners",
                newName: "PartnerId");

            migrationBuilder.RenameColumn(
                name: "next_step_id",
                table: "next_steps",
                newName: "NextStepId");

            migrationBuilder.RenameColumn(
                name: "website",
                table: "Customers",
                newName: "Website");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Customers",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Customers",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "notes",
                table: "Customers",
                newName: "Notes");

            migrationBuilder.RenameColumn(
                name: "industry",
                table: "Customers",
                newName: "Industry");

            migrationBuilder.RenameColumn(
                name: "tax_number",
                table: "Customers",
                newName: "TaxNumber");

            migrationBuilder.RenameColumn(
                name: "modified_by",
                table: "Customers",
                newName: "ModifiedBy");

            migrationBuilder.RenameColumn(
                name: "modified_at",
                table: "Customers",
                newName: "ModifiedAt");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "Customers",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Customers",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "company_name",
                table: "Customers",
                newName: "CompanyName");

            migrationBuilder.RenameColumn(
                name: "billing_country",
                table: "Customers",
                newName: "BillingCountry");

            migrationBuilder.RenameColumn(
                name: "billing_city",
                table: "Customers",
                newName: "BillingCity");

            migrationBuilder.RenameColumn(
                name: "billing_address",
                table: "Customers",
                newName: "BillingAddress");

            migrationBuilder.RenameColumn(
                name: "assigned_to_user_id",
                table: "Customers",
                newName: "AssignedToUserId");

            migrationBuilder.RenameColumn(
                name: "activity_id",
                table: "activities",
                newName: "ActivityId");

            migrationBuilder.AlterColumn<Guid>(
                name: "modified_by",
                table: "users",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "created_by",
                table: "users",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<Guid>(
                name: "id",
                table: "users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "gen_random_uuid()");

            migrationBuilder.AlterColumn<Guid>(
                name: "project_manager_user_id",
                table: "projects",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "modified_by",
                table: "projects",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "customer_id",
                table: "projects",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "created_by",
                table: "projects",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<Guid>(
                name: "id",
                table: "projects",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "gen_random_uuid()");

            migrationBuilder.AlterColumn<Guid>(
                name: "modified_by",
                table: "partners",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "created_by",
                table: "partners",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PartnerId",
                table: "partners",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<Guid>(
                name: "id",
                table: "partners",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "gen_random_uuid()");

            migrationBuilder.AlterColumn<Guid>(
                name: "modified_by",
                table: "next_steps",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "created_by",
                table: "next_steps",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NextStepId",
                table: "next_steps",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<Guid>(
                name: "id",
                table: "next_steps",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "gen_random_uuid()");

            migrationBuilder.AddColumn<Guid>(
                name: "AssignedToId",
                table: "next_steps",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId1",
                table: "next_steps",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectId1",
                table: "next_steps",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ModifiedBy",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "AssignedToUserId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AssignedToId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactFirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactLastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StateProvince",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Customers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "modified_by",
                table: "contacts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "customer_id",
                table: "contacts",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "created_by",
                table: "contacts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<Guid>(
                name: "id",
                table: "contacts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "gen_random_uuid()");

            migrationBuilder.AlterColumn<Guid>(
                name: "modified_by",
                table: "activities",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "created_by",
                table: "activities",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ActivityId",
                table: "activities",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<Guid>(
                name: "id",
                table: "activities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "gen_random_uuid()");

            migrationBuilder.AddColumn<Guid>(
                name: "AssignedToId",
                table: "activities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId1",
                table: "activities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectId1",
                table: "activities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_projects",
                table: "projects",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_partners",
                table: "partners",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_next_steps",
                table: "next_steps",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contacts",
                table: "contacts",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_activities",
                table: "activities",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_next_steps_AssignedToId",
                table: "next_steps",
                column: "AssignedToId");

            migrationBuilder.CreateIndex(
                name: "IX_next_steps_CustomerId1",
                table: "next_steps",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_next_steps_ProjectId1",
                table: "next_steps",
                column: "ProjectId1");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AssignedToId",
                table: "Customers",
                column: "AssignedToId");

            migrationBuilder.CreateIndex(
                name: "IX_activities_AssignedToId",
                table: "activities",
                column: "AssignedToId");

            migrationBuilder.CreateIndex(
                name: "IX_activities_CustomerId1",
                table: "activities",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_activities_ProjectId1",
                table: "activities",
                column: "ProjectId1");

            migrationBuilder.AddForeignKey(
                name: "FK_activities_Customers_CustomerId1",
                table: "activities",
                column: "CustomerId1",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_activities_projects_ProjectId1",
                table: "activities",
                column: "ProjectId1",
                principalTable: "projects",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_activities_users_AssignedToId",
                table: "activities",
                column: "AssignedToId",
                principalTable: "users",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_contacts_Customers_customer_id",
                table: "contacts",
                column: "customer_id",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_users_AssignedToId",
                table: "Customers",
                column: "AssignedToId",
                principalTable: "users",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_next_steps_Customers_CustomerId1",
                table: "next_steps",
                column: "CustomerId1",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_next_steps_projects_ProjectId1",
                table: "next_steps",
                column: "ProjectId1",
                principalTable: "projects",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_next_steps_users_AssignedToId",
                table: "next_steps",
                column: "AssignedToId",
                principalTable: "users",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_projects_Customers_customer_id",
                table: "projects",
                column: "customer_id",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_projects_users_project_manager_user_id",
                table: "projects",
                column: "project_manager_user_id",
                principalTable: "users",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_activities_Customers_CustomerId1",
                table: "activities");

            migrationBuilder.DropForeignKey(
                name: "FK_activities_projects_ProjectId1",
                table: "activities");

            migrationBuilder.DropForeignKey(
                name: "FK_activities_users_AssignedToId",
                table: "activities");

            migrationBuilder.DropForeignKey(
                name: "FK_contacts_Customers_customer_id",
                table: "contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_users_AssignedToId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_next_steps_Customers_CustomerId1",
                table: "next_steps");

            migrationBuilder.DropForeignKey(
                name: "FK_next_steps_projects_ProjectId1",
                table: "next_steps");

            migrationBuilder.DropForeignKey(
                name: "FK_next_steps_users_AssignedToId",
                table: "next_steps");

            migrationBuilder.DropForeignKey(
                name: "FK_projects_Customers_customer_id",
                table: "projects");

            migrationBuilder.DropForeignKey(
                name: "FK_projects_users_project_manager_user_id",
                table: "projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_projects",
                table: "projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_partners",
                table: "partners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_next_steps",
                table: "next_steps");

            migrationBuilder.DropIndex(
                name: "IX_next_steps_AssignedToId",
                table: "next_steps");

            migrationBuilder.DropIndex(
                name: "IX_next_steps_CustomerId1",
                table: "next_steps");

            migrationBuilder.DropIndex(
                name: "IX_next_steps_ProjectId1",
                table: "next_steps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_AssignedToId",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_contacts",
                table: "contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_activities",
                table: "activities");

            migrationBuilder.DropIndex(
                name: "IX_activities_AssignedToId",
                table: "activities");

            migrationBuilder.DropIndex(
                name: "IX_activities_CustomerId1",
                table: "activities");

            migrationBuilder.DropIndex(
                name: "IX_activities_ProjectId1",
                table: "activities");

            migrationBuilder.DropColumn(
                name: "id",
                table: "users");

            migrationBuilder.DropColumn(
                name: "id",
                table: "projects");

            migrationBuilder.DropColumn(
                name: "id",
                table: "partners");

            migrationBuilder.DropColumn(
                name: "id",
                table: "next_steps");

            migrationBuilder.DropColumn(
                name: "AssignedToId",
                table: "next_steps");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "next_steps");

            migrationBuilder.DropColumn(
                name: "ProjectId1",
                table: "next_steps");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "AssignedToId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ContactFirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ContactLastName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "StateProvince",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "id",
                table: "contacts");

            migrationBuilder.DropColumn(
                name: "id",
                table: "activities");

            migrationBuilder.DropColumn(
                name: "AssignedToId",
                table: "activities");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "activities");

            migrationBuilder.DropColumn(
                name: "ProjectId1",
                table: "activities");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "customers");

            migrationBuilder.RenameColumn(
                name: "last_login",
                table: "users",
                newName: "last_login_date");

            migrationBuilder.RenameColumn(
                name: "PartnerId",
                table: "partners",
                newName: "partner_id");

            migrationBuilder.RenameColumn(
                name: "NextStepId",
                table: "next_steps",
                newName: "next_step_id");

            migrationBuilder.RenameColumn(
                name: "Website",
                table: "customers",
                newName: "website");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "customers",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "customers",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "customers",
                newName: "notes");

            migrationBuilder.RenameColumn(
                name: "Industry",
                table: "customers",
                newName: "industry");

            migrationBuilder.RenameColumn(
                name: "TaxNumber",
                table: "customers",
                newName: "tax_number");

            migrationBuilder.RenameColumn(
                name: "ModifiedBy",
                table: "customers",
                newName: "modified_by");

            migrationBuilder.RenameColumn(
                name: "ModifiedAt",
                table: "customers",
                newName: "modified_at");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "customers",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "customers",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "customers",
                newName: "company_name");

            migrationBuilder.RenameColumn(
                name: "BillingCountry",
                table: "customers",
                newName: "billing_country");

            migrationBuilder.RenameColumn(
                name: "BillingCity",
                table: "customers",
                newName: "billing_city");

            migrationBuilder.RenameColumn(
                name: "BillingAddress",
                table: "customers",
                newName: "billing_address");

            migrationBuilder.RenameColumn(
                name: "AssignedToUserId",
                table: "customers",
                newName: "assigned_to_user_id");

            migrationBuilder.RenameColumn(
                name: "ActivityId",
                table: "activities",
                newName: "activity_id");

            migrationBuilder.AlterColumn<int>(
                name: "modified_by",
                table: "users",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "created_by",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "user_id",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "project_manager_user_id",
                table: "projects",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "modified_by",
                table: "projects",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "customer_id",
                table: "projects",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "created_by",
                table: "projects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "project_id",
                table: "projects",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "modified_by",
                table: "partners",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "created_by",
                table: "partners",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "partner_id",
                table: "partners",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "modified_by",
                table: "next_steps",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "created_by",
                table: "next_steps",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "next_step_id",
                table: "next_steps",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "modified_by",
                table: "customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "created_by",
                table: "customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "assigned_to_user_id",
                table: "customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "customer_id",
                table: "customers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "modified_by",
                table: "contacts",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "customer_id",
                table: "contacts",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "created_by",
                table: "contacts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "contact_id",
                table: "contacts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "modified_by",
                table: "activities",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "created_by",
                table: "activities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "activity_id",
                table: "activities",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "user_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_projects",
                table: "projects",
                column: "project_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_partners",
                table: "partners",
                column: "partner_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_next_steps",
                table: "next_steps",
                column: "next_step_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customers",
                table: "customers",
                column: "customer_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contacts",
                table: "contacts",
                column: "contact_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_activities",
                table: "activities",
                column: "activity_id");

            migrationBuilder.CreateIndex(
                name: "IX_next_steps_assigned_to_user_id",
                table: "next_steps",
                column: "assigned_to_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_next_steps_customer_id",
                table: "next_steps",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_next_steps_project_id",
                table: "next_steps",
                column: "project_id");

            migrationBuilder.CreateIndex(
                name: "IX_customers_assigned_to_user_id",
                table: "customers",
                column: "assigned_to_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_activities_assigned_to_user_id",
                table: "activities",
                column: "assigned_to_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_activities_customer_id",
                table: "activities",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_activities_project_id",
                table: "activities",
                column: "project_id");

            migrationBuilder.AddForeignKey(
                name: "FK_activities_customers_customer_id",
                table: "activities",
                column: "customer_id",
                principalTable: "customers",
                principalColumn: "customer_id");

            migrationBuilder.AddForeignKey(
                name: "FK_activities_projects_project_id",
                table: "activities",
                column: "project_id",
                principalTable: "projects",
                principalColumn: "project_id");

            migrationBuilder.AddForeignKey(
                name: "FK_activities_users_assigned_to_user_id",
                table: "activities",
                column: "assigned_to_user_id",
                principalTable: "users",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_contacts_customers_customer_id",
                table: "contacts",
                column: "customer_id",
                principalTable: "customers",
                principalColumn: "customer_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_customers_users_assigned_to_user_id",
                table: "customers",
                column: "assigned_to_user_id",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_next_steps_customers_customer_id",
                table: "next_steps",
                column: "customer_id",
                principalTable: "customers",
                principalColumn: "customer_id");

            migrationBuilder.AddForeignKey(
                name: "FK_next_steps_projects_project_id",
                table: "next_steps",
                column: "project_id",
                principalTable: "projects",
                principalColumn: "project_id");

            migrationBuilder.AddForeignKey(
                name: "FK_next_steps_users_assigned_to_user_id",
                table: "next_steps",
                column: "assigned_to_user_id",
                principalTable: "users",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_projects_customers_customer_id",
                table: "projects",
                column: "customer_id",
                principalTable: "customers",
                principalColumn: "customer_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_projects_users_project_manager_user_id",
                table: "projects",
                column: "project_manager_user_id",
                principalTable: "users",
                principalColumn: "user_id");
        }
    }
}
