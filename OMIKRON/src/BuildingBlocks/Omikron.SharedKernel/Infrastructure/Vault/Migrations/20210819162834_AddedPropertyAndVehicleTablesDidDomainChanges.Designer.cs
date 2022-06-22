﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Omikron.SharedKernel.Infrastructure.Vault.Data;

namespace Omikron.SharedKernel.Infrastructure.Vault.Migrations
{
    [DbContext(typeof(VaultServiceDatabaseContext))]
    [Migration("20210819162834_AddedPropertyAndVehicleTablesDidDomainChanges")]
    partial class AddedPropertyAndVehicleTablesDidDomainChanges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("vault")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Omikron.VaultService.Domain.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ExternalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IdentificationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LoanTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Source")
                        .HasColumnType("int");

                    b.Property<int?>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LoanTypeId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Omikron.VaultService.Domain.Models.AccountIdentificationNumber", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SortCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccountIdentificationNumber");
                });

            modelBuilder.Entity("Omikron.VaultService.Domain.Models.AccountType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccountType");
                });

            modelBuilder.Entity("Omikron.VaultService.Domain.Models.CustomerId", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.ToTable("CustomerId");
                });

            modelBuilder.Entity("Omikron.VaultService.Domain.Models.LoanType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoanType");
                });

            modelBuilder.Entity("Omikron.VaultService.Domain.Models.Property", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ExternalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MortgageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MortgageId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("Omikron.VaultService.Domain.Models.VaultItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("AccountExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AccountIdentificationNumberId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AccountTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("HostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ItemTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerIdId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AccountIdentificationNumberId");

                    b.HasIndex("AccountTypeId");

                    b.HasIndex("ItemTypeId");

                    b.HasIndex("OwnerIdId");

                    b.ToTable("VaultItems");
                });

            modelBuilder.Entity("Omikron.VaultService.Domain.Models.VaultItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VaultItemType");
                });

            modelBuilder.Entity("Omikron.VaultService.Domain.Models.VaultItemValue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AccountVaultItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("PropertyVaultItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<Guid>("VaultItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("VehicleVaultItemId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AccountVaultItemId");

                    b.HasIndex("PropertyVaultItemId");

                    b.HasIndex("VehicleVaultItemId");

                    b.ToTable("VaultItemValues");
                });

            modelBuilder.Entity("Omikron.VaultService.Domain.Models.Vehicle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ExternalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FinancialAgreementId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mileage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Registration")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FinancialAgreementId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Omikron.VaultService.Domain.Models.Account", b =>
                {
                    b.HasOne("Omikron.VaultService.Domain.Models.LoanType", "LoanType")
                        .WithMany()
                        .HasForeignKey("LoanTypeId");

                    b.Navigation("LoanType");
                });

            modelBuilder.Entity("Omikron.VaultService.Domain.Models.Property", b =>
                {
                    b.HasOne("Omikron.VaultService.Domain.Models.Account", "Mortgage")
                        .WithMany("Properties")
                        .HasForeignKey("MortgageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mortgage");
                });

            modelBuilder.Entity("Omikron.VaultService.Domain.Models.VaultItem", b =>
                {
                    b.HasOne("Omikron.VaultService.Domain.Models.AccountIdentificationNumber", "AccountIdentificationNumber")
                        .WithMany()
                        .HasForeignKey("AccountIdentificationNumberId");

                    b.HasOne("Omikron.VaultService.Domain.Models.AccountType", "AccountType")
                        .WithMany()
                        .HasForeignKey("AccountTypeId");

                    b.HasOne("Omikron.VaultService.Domain.Models.VaultItemType", "ItemType")
                        .WithMany()
                        .HasForeignKey("ItemTypeId");

                    b.HasOne("Omikron.VaultService.Domain.Models.CustomerId", "OwnerId")
                        .WithMany()
                        .HasForeignKey("OwnerIdId");

                    b.Navigation("AccountIdentificationNumber");

                    b.Navigation("AccountType");

                    b.Navigation("ItemType");

                    b.Navigation("OwnerId");
                });

            modelBuilder.Entity("Omikron.VaultService.Domain.Models.VaultItemValue", b =>
                {
                    b.HasOne("Omikron.VaultService.Domain.Models.Account", "AccountVaultItem")
                        .WithMany("Values")
                        .HasForeignKey("AccountVaultItemId");

                    b.HasOne("Omikron.VaultService.Domain.Models.Property", "PropertyVaultItem")
                        .WithMany("Values")
                        .HasForeignKey("PropertyVaultItemId");

                    b.HasOne("Omikron.VaultService.Domain.Models.Vehicle", "VehicleVaultItem")
                        .WithMany("Values")
                        .HasForeignKey("VehicleVaultItemId");

                    b.Navigation("AccountVaultItem");

                    b.Navigation("PropertyVaultItem");

                    b.Navigation("VehicleVaultItem");
                });

            modelBuilder.Entity("Omikron.VaultService.Domain.Models.Vehicle", b =>
                {
                    b.HasOne("Omikron.VaultService.Domain.Models.Account", "FinancialAgreement")
                        .WithMany("Vehicles")
                        .HasForeignKey("FinancialAgreementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FinancialAgreement");
                });

            modelBuilder.Entity("Omikron.VaultService.Domain.Models.Account", b =>
                {
                    b.Navigation("Properties");

                    b.Navigation("Values");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Omikron.VaultService.Domain.Models.Property", b =>
                {
                    b.Navigation("Values");
                });

            modelBuilder.Entity("Omikron.VaultService.Domain.Models.Vehicle", b =>
                {
                    b.Navigation("Values");
                });
#pragma warning restore 612, 618
        }
    }
}