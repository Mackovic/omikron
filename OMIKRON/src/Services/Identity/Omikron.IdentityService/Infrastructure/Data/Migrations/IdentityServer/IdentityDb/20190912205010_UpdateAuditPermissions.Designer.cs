﻿// <auto-generated />
using System;
using Omikron.IdentityService.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Omikron.IdentityService.Infrastructure.Data.Migrations.IdentityServer.IdentityDb
{
    [DbContext(typeof(OmikronIdentityDbContext))]
    [Migration("20190912205010_UpdateAuditPermissions")]
    partial class UpdateAuditPermissions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("usm")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Omikron.IdentityService.Infrastructure.Data.Model.ConfirmationToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("Expiration");

                    b.Property<string>("TenantId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("Type");

                    b.Property<int>("UserId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ConfirmationTokens");
                });

            modelBuilder.Entity("Omikron.IdentityService.Infrastructure.Data.Model.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<int>("Domain");

                    b.Property<Guid>("ExternalId");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("NormalizedName")
                        .IsRequired();

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2019, 9, 12, 20, 50, 9, 624, DateTimeKind.Utc).AddTicks(3907),
                            Description = "Ability to see a page with a list of tenants alongside with search functionality.",
                            Domain = 1,
                            ExternalId = new Guid("18bb49e7-69ed-47bd-bfc6-5372dd15315a"),
                            Name = "Search.Tenants",
                            NormalizedName = "SEARCH.TENANTS"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2019, 9, 12, 20, 50, 9, 624, DateTimeKind.Utc).AddTicks(7250),
                            Description = "Ability to see button for add tenant alongside with ability to create tenant. Required Permissions: Search.Tenants",
                            Domain = 1,
                            ExternalId = new Guid("9feb92a5-398f-4069-8f5f-6da5212af3f2"),
                            Name = "Add.Tenant",
                            NormalizedName = "ADD.TENANT"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2019, 9, 12, 20, 50, 9, 624, DateTimeKind.Utc).AddTicks(7311),
                            Description = "Ability to navigate to tenant details page and edit tenant. Required Permissions: Search.Tenants",
                            Domain = 1,
                            ExternalId = new Guid("cba862dc-fd5f-4c70-84a6-3fb16cb868e1"),
                            Name = "Edit.Tenant",
                            NormalizedName = "EDIT.TENANT"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2019, 9, 12, 20, 50, 9, 624, DateTimeKind.Utc).AddTicks(7317),
                            Description = "Ability to navigate to tenant details page without ability to edit tenant. Required Permissions: Search.Tenants",
                            Domain = 1,
                            ExternalId = new Guid("865dd083-5872-406a-bf8b-bd440f31d6fe"),
                            Name = "Read.Tenant",
                            NormalizedName = "READ.TENANT"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2019, 9, 12, 20, 50, 9, 624, DateTimeKind.Utc).AddTicks(7321),
                            Description = "Ability to see delete action alongside with ability to delete tenant. Required Permissions: Search.Tenants, Edit.Tenant",
                            Domain = 1,
                            ExternalId = new Guid("e445a667-0a50-470f-84d5-84959adca363"),
                            Name = "Delete.Tenant",
                            NormalizedName = "DELETE.TENANT"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2019, 9, 12, 20, 50, 9, 624, DateTimeKind.Utc).AddTicks(7328),
                            Description = "Ability to see a page with a list of users alongside with search functionality.",
                            Domain = 2,
                            ExternalId = new Guid("8d5e1370-d20c-4e2e-9a93-84f5d4e620c4"),
                            Name = "Search.Users",
                            NormalizedName = "SEARCH.USERS"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2019, 9, 12, 20, 50, 9, 624, DateTimeKind.Utc).AddTicks(7332),
                            Description = "Ability to see button for add user alongside with ability to create user. Required Permissions: Search.Users",
                            Domain = 2,
                            ExternalId = new Guid("0ebcb068-fe5b-4696-9392-eca13615139c"),
                            Name = "Add.User",
                            NormalizedName = "ADD.USER"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2019, 9, 12, 20, 50, 9, 624, DateTimeKind.Utc).AddTicks(7336),
                            Description = "Ability to navigate to user details page and edit user. Required Permissions: Search.Users",
                            Domain = 2,
                            ExternalId = new Guid("9c0d6b32-6f5f-41a3-8336-43f33dd61477"),
                            Name = "Edit.User",
                            NormalizedName = "EDIT.USER"
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2019, 9, 12, 20, 50, 9, 624, DateTimeKind.Utc).AddTicks(7340),
                            Description = "Ability to see delete action alongside with ability to delete user. Required Permissions: Search.Users, Edit.User",
                            Domain = 2,
                            ExternalId = new Guid("d686c12f-8ac8-4214-a1a2-e8b7d02b18ad"),
                            Name = "Delete.User",
                            NormalizedName = "DELETE.USER"
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2019, 9, 12, 20, 50, 9, 624, DateTimeKind.Utc).AddTicks(7345),
                            Description = "Ability to navigate to user details page without ability to edit user. Required Permissions: Search.Users",
                            Domain = 2,
                            ExternalId = new Guid("57c57548-266d-4cd3-a35e-de256c6cedd8"),
                            Name = "Read.User",
                            NormalizedName = "READ.USER"
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2019, 9, 12, 20, 50, 9, 624, DateTimeKind.Utc).AddTicks(7349),
                            Description = "Ability to see a page with a list of roles alongside with search functionality.",
                            Domain = 3,
                            ExternalId = new Guid("42dc28e4-deca-41bf-960f-f63d4ad41e43"),
                            Name = "Search.Roles",
                            NormalizedName = "SEARCH.ROLES"
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2019, 9, 12, 20, 50, 9, 624, DateTimeKind.Utc).AddTicks(7353),
                            Description = "Ability to see button for add role alongside with ability to create role. Required Permissions: Search.Roles",
                            Domain = 3,
                            ExternalId = new Guid("dd37cf7c-da69-4136-8d0b-96f2f40563c4"),
                            Name = "Add.Role",
                            NormalizedName = "ADD.ROLE"
                        },
                        new
                        {
                            Id = 13,
                            CreatedAt = new DateTime(2019, 9, 12, 20, 50, 9, 624, DateTimeKind.Utc).AddTicks(7356),
                            Description = "Ability to navigate to role details page and edit role. Required Permissions: Search.Roles, Edit.Roles",
                            Domain = 3,
                            ExternalId = new Guid("e4cc40f5-2100-497d-8b58-33667376a99a"),
                            Name = "Edit.Role",
                            NormalizedName = "EDIT.ROLE"
                        },
                        new
                        {
                            Id = 14,
                            CreatedAt = new DateTime(2019, 9, 12, 20, 50, 9, 624, DateTimeKind.Utc).AddTicks(7360),
                            Description = "Ability to see delete action alongside with ability to delete role. Required Permissions: Search.Roles, Edit.Roles",
                            Domain = 3,
                            ExternalId = new Guid("426d5137-c41c-4962-a1e0-3fa5c1dbbc45"),
                            Name = "Delete.Role",
                            NormalizedName = "DELETE.ROLE"
                        },
                        new
                        {
                            Id = 15,
                            CreatedAt = new DateTime(2019, 9, 12, 20, 50, 9, 624, DateTimeKind.Utc).AddTicks(7364),
                            Description = "Ability to navigate to role details page without ability to edit role. Required Permissions: Search.Roles",
                            Domain = 3,
                            ExternalId = new Guid("0d6dac73-8728-4d9f-951f-ef4db97c996f"),
                            Name = "Read.Role",
                            NormalizedName = "READ.ROLE"
                        },
                        new
                        {
                            Id = 16,
                            CreatedAt = new DateTime(2019, 9, 12, 20, 50, 9, 624, DateTimeKind.Utc).AddTicks(7368),
                            Description = "Ability to run into interactive view in order to see required permissions for protected parts of the system.",
                            Domain = 3,
                            ExternalId = new Guid("68e3c31c-aade-41d0-88ba-9048e7233b12"),
                            Name = "Interactive.View",
                            NormalizedName = "INTERACTIVE.VIEW"
                        },
                        new
                        {
                            Id = 17,
                            CreatedAt = new DateTime(2019, 9, 12, 20, 50, 9, 624, DateTimeKind.Utc).AddTicks(7372),
                            Description = "Ability to trace data for particular tenant. The permission includes also the ability to see data content what was changed.",
                            Domain = 4,
                            ExternalId = new Guid("77fadd97-22d3-489e-882e-b106f6805bdf"),
                            Name = "Search.DataChangeLogs",
                            NormalizedName = "SEARCH.DATACHANGELOGS"
                        },
                        new
                        {
                            Id = 18,
                            CreatedAt = new DateTime(2019, 9, 12, 20, 50, 9, 624, DateTimeKind.Utc).AddTicks(7440),
                            Description = "Ability to trace data for all tenants. The permission includes also the ability to see data content what was changed.",
                            Domain = 1,
                            ExternalId = new Guid("c5b037e8-1df3-4bc0-92fd-b1cd5c1a1d17"),
                            Name = "Search.DataChangeLogs.ByTenant",
                            NormalizedName = "SEARCH.DATACHANGELOGS.BYTENANT"
                        });
                });

            modelBuilder.Entity("Omikron.IdentityService.Infrastructure.Data.Model.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<bool>("Enabled");

                    b.Property<Guid>("ExternalId");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "0e5c0f645cc34d0e82c0005327c14bfb",
                            Description = "Tenant Administrator Role is a system role and represents the role with the ability to managing users and roles for the tenant. This role cannot be deleted or edit since it's not a user-defined role.",
                            Enabled = true,
                            ExternalId = new Guid("dffa36f1-df2a-419d-9387-a32509a14d69"),
                            Name = "Tenant.Administrator",
                            NormalizedName = "TENANT.ADMINISTRATOR",
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "12d1fb1d5ba34e87b8d60414c890a9f9",
                            Description = "System Tenant Administrator Role is a system role and represents the role with the ability to managing tenants users and roles for the main tenant. This role cannot be deleted or edit since it's not a user-defined role.",
                            Enabled = true,
                            ExternalId = new Guid("cb6165cb-4cdf-4fdc-9951-71a9a0485fb9"),
                            Name = "System.Tenant.Administrator",
                            NormalizedName = "SYSTEM.TENANT.ADMINISTRATOR",
                            Type = 1
                        });
                });

            modelBuilder.Entity("Omikron.IdentityService.Infrastructure.Data.Model.RolePermission", b =>
                {
                    b.Property<int>("PermissionId");

                    b.Property<int>("RoleId");

                    b.HasKey("PermissionId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePermission");

                    b.HasData(
                        new
                        {
                            PermissionId = 1,
                            RoleId = 2
                        },
                        new
                        {
                            PermissionId = 2,
                            RoleId = 2
                        },
                        new
                        {
                            PermissionId = 3,
                            RoleId = 2
                        },
                        new
                        {
                            PermissionId = 4,
                            RoleId = 2
                        },
                        new
                        {
                            PermissionId = 5,
                            RoleId = 2
                        },
                        new
                        {
                            PermissionId = 6,
                            RoleId = 2
                        },
                        new
                        {
                            PermissionId = 7,
                            RoleId = 2
                        },
                        new
                        {
                            PermissionId = 8,
                            RoleId = 2
                        },
                        new
                        {
                            PermissionId = 9,
                            RoleId = 2
                        },
                        new
                        {
                            PermissionId = 10,
                            RoleId = 2
                        },
                        new
                        {
                            PermissionId = 11,
                            RoleId = 2
                        },
                        new
                        {
                            PermissionId = 12,
                            RoleId = 2
                        },
                        new
                        {
                            PermissionId = 13,
                            RoleId = 2
                        },
                        new
                        {
                            PermissionId = 14,
                            RoleId = 2
                        },
                        new
                        {
                            PermissionId = 15,
                            RoleId = 2
                        },
                        new
                        {
                            PermissionId = 16,
                            RoleId = 2
                        },
                        new
                        {
                            PermissionId = 17,
                            RoleId = 2
                        },
                        new
                        {
                            PermissionId = 18,
                            RoleId = 2
                        },
                        new
                        {
                            PermissionId = 6,
                            RoleId = 1
                        },
                        new
                        {
                            PermissionId = 7,
                            RoleId = 1
                        },
                        new
                        {
                            PermissionId = 8,
                            RoleId = 1
                        },
                        new
                        {
                            PermissionId = 9,
                            RoleId = 1
                        },
                        new
                        {
                            PermissionId = 10,
                            RoleId = 1
                        },
                        new
                        {
                            PermissionId = 11,
                            RoleId = 1
                        },
                        new
                        {
                            PermissionId = 12,
                            RoleId = 1
                        },
                        new
                        {
                            PermissionId = 13,
                            RoleId = 1
                        },
                        new
                        {
                            PermissionId = 14,
                            RoleId = 1
                        },
                        new
                        {
                            PermissionId = 15,
                            RoleId = 1
                        },
                        new
                        {
                            PermissionId = 16,
                            RoleId = 1
                        },
                        new
                        {
                            PermissionId = 17,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("Omikron.IdentityService.Infrastructure.Data.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<int>("AccountStatus");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<Guid>("ExternalId");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("ProfilePhoto")
                        .HasMaxLength(550);

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Finbuckle.MultiTenant.MultiTenantIdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.Property<string>("TenantId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Finbuckle.MultiTenant.MultiTenantIdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("TenantId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Finbuckle.MultiTenant.MultiTenantIdentityUserLogin<int>", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider")
                        .IsRequired();

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("ProviderKey")
                        .IsRequired();

                    b.Property<string>("TenantId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("LoginProvider", "ProviderKey", "TenantId")
                        .IsUnique();

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Finbuckle.MultiTenant.MultiTenantIdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.Property<string>("TenantId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Finbuckle.MultiTenant.MultiTenantIdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("TenantId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Omikron.IdentityService.Infrastructure.Data.Model.ConfirmationToken", b =>
                {
                    b.HasOne("Omikron.IdentityService.Infrastructure.Data.Model.User", "User")
                        .WithMany("ConfirmationTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Omikron.IdentityService.Infrastructure.Data.Model.RolePermission", b =>
                {
                    b.HasOne("Omikron.IdentityService.Infrastructure.Data.Model.Permission", "Permission")
                        .WithMany("AssignedRoles")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Omikron.IdentityService.Infrastructure.Data.Model.Role", "Role")
                        .WithMany("AssignedPermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Finbuckle.MultiTenant.MultiTenantIdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Omikron.IdentityService.Infrastructure.Data.Model.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Finbuckle.MultiTenant.MultiTenantIdentityUserClaim<int>", b =>
                {
                    b.HasOne("Omikron.IdentityService.Infrastructure.Data.Model.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Finbuckle.MultiTenant.MultiTenantIdentityUserLogin<int>", b =>
                {
                    b.HasOne("Omikron.IdentityService.Infrastructure.Data.Model.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Finbuckle.MultiTenant.MultiTenantIdentityUserRole<int>", b =>
                {
                    b.HasOne("Omikron.IdentityService.Infrastructure.Data.Model.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Omikron.IdentityService.Infrastructure.Data.Model.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Finbuckle.MultiTenant.MultiTenantIdentityUserToken<int>", b =>
                {
                    b.HasOne("Omikron.IdentityService.Infrastructure.Data.Model.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
