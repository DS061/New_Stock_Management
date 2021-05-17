﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using New_Stock_Management.Data;

namespace New_Stock_Management.Migrations
{
    [DbContext(typeof(New_Stock_ManagementContext))]
    partial class New_Stock_ManagementContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("New_Stock_Management.Models.Bill_Payment_Master", b =>
                {
                    b.Property<int>("Bill_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Company_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Payment_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Bill_ID");

                    b.ToTable("Bill_Payment_Master");
                });

            modelBuilder.Entity("New_Stock_Management.Models.Client_Master", b =>
                {
                    b.Property<int>("Client_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Client_Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Client_Edate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Client_Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Client_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Client_ID");

                    b.ToTable("Client_Master");
                });

            modelBuilder.Entity("New_Stock_Management.Models.Company_Master", b =>
                {
                    b.Property<int>("Company_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Company_Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Company_Edate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Company_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact_Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Company_ID");

                    b.ToTable("Company_Master");
                });

            modelBuilder.Entity("New_Stock_Management.Models.Payment_Master", b =>
                {
                    b.Property<int>("Payment_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Paid_Amt")
                        .HasColumnType("int");

                    b.Property<string>("Party_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Payment_Edate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Payment_ID");

                    b.ToTable("Payment_Master");
                });

            modelBuilder.Entity("New_Stock_Management.Models.Sale_Master", b =>
                {
                    b.Property<int>("Sale_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bill_No")
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Item_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Party_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<DateTime>("Stock_Edate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Total_Price")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Sale_ID");

                    b.ToTable("Sale_Master");
                });

            modelBuilder.Entity("New_Stock_Management.Models.Stock_Master", b =>
                {
                    b.Property<int>("Stock_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Available_Price")
                        .HasColumnType("int");

                    b.Property<int>("Available_Qty")
                        .HasColumnType("int");

                    b.Property<string>("Company_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Item_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sell_Qty")
                        .HasColumnType("int");

                    b.Property<int>("Total_Qty")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("sell_price")
                        .HasColumnType("int");

                    b.HasKey("Stock_ID");

                    b.ToTable("Stock_Master");
                });

            modelBuilder.Entity("New_Stock_Management.Models.Stock_Return_Master", b =>
                {
                    b.Property<int>("Stock_return_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Item_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<DateTime>("Stock_Edate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Total_Price")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Stock_return_ID");

                    b.ToTable("Stock_Return_Master");
                });

            modelBuilder.Entity("New_Stock_Management.Models.Stock_in_Master", b =>
                {
                    b.Property<int>("Stock_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Buy_Price")
                        .HasColumnType("int");

                    b.Property<string>("Company_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Item_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<int>("Sell_Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("Stock_Edate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Stock_ID");

                    b.ToTable("Stock_in_Master");
                });
#pragma warning restore 612, 618
        }
    }
}
