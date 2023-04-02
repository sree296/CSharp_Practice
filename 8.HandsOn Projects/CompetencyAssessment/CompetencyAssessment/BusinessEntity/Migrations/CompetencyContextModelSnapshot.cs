﻿// <auto-generated />
using System;
using BusinessEntity.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessEntity.Migrations
{
    [DbContext(typeof(CompetencyContext))]
    partial class CompetencyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BusinessEntity.BEModels.AssessmentDetail", b =>
                {
                    b.Property<int>("AssmtID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssmtID"));

                    b.Property<DateTime>("AssmtDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AssmtName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("AssmtID");

                    b.ToTable("AssessmentDetails");
                });

            modelBuilder.Entity("BusinessEntity.BEModels.CaseStudyDetail", b =>
                {
                    b.Property<int>("CSID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CSID"));

                    b.Property<int>("AssessmentID")
                        .HasColumnType("int");

                    b.Property<string>("CareatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CaseStudyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ReviewStatus")
                        .HasColumnType("bit");

                    b.HasKey("CSID");

                    b.ToTable("CaseStudyDetails");
                });

            modelBuilder.Entity("BusinessEntity.BEModels.CaseStudySolution", b =>
                {
                    b.Property<int>("CSSID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CSSID"));

                    b.Property<int>("CaseStudtID")
                        .HasColumnType("int");

                    b.Property<int>("CompetencyID")
                        .HasColumnType("int");

                    b.Property<string>("SolutionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CSSID");

                    b.ToTable("CaseStudySolutions");
                });

            modelBuilder.Entity("BusinessEntity.BEModels.CompetencyDetail", b =>
                {
                    b.Property<int>("CompId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompId"));

                    b.Property<string>("CompetencyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompId");

                    b.ToTable("CompetencyDetails");
                });

            modelBuilder.Entity("BusinessEntity.BEModels.RoleDetail", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("RoleDetails");
                });

            modelBuilder.Entity("BusinessEntity.BEModels.UserInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PasswordChangeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("UserInfoData");
                });
#pragma warning restore 612, 618
        }
    }
}
