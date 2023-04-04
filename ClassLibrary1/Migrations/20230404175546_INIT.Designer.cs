﻿// <auto-generated />
using Graduation.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Graduation.DAL.Migrations
{
    [DbContext(typeof(GraduationDBContext))]
<<<<<<<< HEAD:ClassLibrary1/Migrations/20230404175546_INIT.Designer.cs
    [Migration("20230404175546_INIT")]
    partial class INIT
========
    [Migration("20230328154549_init")]
    partial class init
>>>>>>>> bfd84c7ee5a21fc5d5c02c44cb7b480318ec778f:ClassLibrary1/Migrations/20230328154549_init.Designer.cs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccessLayer.Entities.ChairsEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Chairs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InstituteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InstituteId");

                    b.ToTable("Chairs");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.GroupEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.InstituteEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Institute")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Institutes");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.LecturerEntitiy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lecturers");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.LecturerGroupEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("LecturerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("LecturerId");

                    b.ToTable("LecturerGroups");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.SectionEntitiy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ChairsId")
                        .HasColumnType("int");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChairsId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.StudentEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Students");
                });

<<<<<<<< HEAD:ClassLibrary1/Migrations/20230404175546_INIT.Designer.cs
            modelBuilder.Entity("Graduation.DAL.Entitiys.GradedEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Course")
                        .HasColumnType("int");

                    b.Property<int>("Graded1")
                        .HasColumnType("int");

                    b.Property<int>("Graded2")
                        .HasColumnType("int");

                    b.Property<int>("Graded3")
                        .HasColumnType("int");

                    b.Property<int>("Graded4")
                        .HasColumnType("int");

                    b.Property<int>("Mog")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("Subject1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Gradeds");
                });

            modelBuilder.Entity("Graduation.DAL.Entitiys.SubjectEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Credit")
                        .HasColumnType("int");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

========
>>>>>>>> bfd84c7ee5a21fc5d5c02c44cb7b480318ec778f:ClassLibrary1/Migrations/20230328154549_init.Designer.cs
            modelBuilder.Entity("DataAccessLayer.Entities.ChairsEntity", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.InstituteEntity", "Institute")
                        .WithMany("Chairs")
                        .HasForeignKey("InstituteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Institute");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.GroupEntity", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.SectionEntitiy", "Section")
                        .WithMany("Groups")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Section");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.LecturerGroupEntity", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.GroupEntity", "Group")
                        .WithMany("LecturerGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccessLayer.Entities.LecturerEntitiy", "Lecturer")
                        .WithMany("LecturerGroups")
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Lecturer");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.SectionEntitiy", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.ChairsEntity", "Chairs")
                        .WithMany("Sections")
                        .HasForeignKey("ChairsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chairs");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.StudentEntity", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.GroupEntity", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

<<<<<<<< HEAD:ClassLibrary1/Migrations/20230404175546_INIT.Designer.cs
            modelBuilder.Entity("Graduation.DAL.Entitiys.GradedEntity", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.StudentEntity", "Student")
                        .WithMany("Gradeds")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

========
>>>>>>>> bfd84c7ee5a21fc5d5c02c44cb7b480318ec778f:ClassLibrary1/Migrations/20230328154549_init.Designer.cs
            modelBuilder.Entity("DataAccessLayer.Entities.ChairsEntity", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.GroupEntity", b =>
                {
                    b.Navigation("LecturerGroups");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.InstituteEntity", b =>
                {
                    b.Navigation("Chairs");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.LecturerEntitiy", b =>
                {
                    b.Navigation("LecturerGroups");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.SectionEntitiy", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.StudentEntity", b =>
                {
                    b.Navigation("Gradeds");
                });
#pragma warning restore 612, 618
        }
    }
}
