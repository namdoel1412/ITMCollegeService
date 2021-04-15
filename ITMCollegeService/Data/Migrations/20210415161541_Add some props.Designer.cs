﻿// <auto-generated />
using System;
using ITMCollegeService.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ITMCollegeService.Data.Migrations
{
    [DbContext(typeof(ITMCollegeContext))]
    [Migration("20210415161541_Add some props")]
    partial class Addsomeprops
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("ITMCollegeService.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250) CHARACTER SET utf8mb4")
                        .HasColumnName("address");

                    b.Property<DateTime?>("Created_At")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("email");

                    b.Property<int>("GenderId")
                        .HasColumnType("int")
                        .HasColumnName("gender_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("phone");

                    b.Property<DateTime?>("Updated_At")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "GenderId" }, "FKadmin34186");

                    b.ToTable("admin");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<byte>("IsOnHeader")
                        .HasColumnType("tinyint unsigned")
                        .HasColumnName("isOnHeader");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("category");
                });

            modelBuilder.Entity("ITMCollegeService.Models.CategoryNews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<int>("NewsId")
                        .HasColumnType("int")
                        .HasColumnName("news_id");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "NewsId" }, "FKcategory_n779857");

                    b.HasIndex(new[] { "CategoryId" }, "FKcategory_n984463");

                    b.ToTable("category_news");
                });

            modelBuilder.Entity("ITMCollegeService.Models.College", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasColumnName("description");

                    b.Property<string>("Icon")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasColumnName("icon");

                    b.Property<string>("Logo")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasColumnName("logo");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("college");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Collegeaddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasColumnName("address");

                    b.Property<int?>("CollegeId")
                        .HasColumnType("int")
                        .HasColumnName("college_id");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("email");

                    b.Property<byte>("IsMainFacility")
                        .HasColumnType("tinyint unsigned")
                        .HasColumnName("isMainFacility");

                    b.Property<string>("MapApi")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasColumnName("mapApi");

                    b.Property<string>("Phone")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("phone");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CollegeId" }, "college_id");

                    b.ToTable("collegeaddress");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasColumnName("content");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("email");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("phone");

                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("status_id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "StatusId" }, "FKcontact152934");

                    b.ToTable("contact");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("code");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int")
                        .HasColumnName("department_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("name");

                    b.Property<int>("SemesterId")
                        .HasColumnType("int")
                        .HasColumnName("semester_id");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "DepartmentId" }, "FKcourse1975");

                    b.HasIndex(new[] { "SemesterId" }, "FKcourse261733");

                    b.ToTable("course");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("code");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int")
                        .HasColumnName("faculty_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "FacultyId" }, "FKdepartment546596");

                    b.ToTable("department");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("phone");

                    b.HasKey("Id");

                    b.ToTable("faculty");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("gender");
                });

            modelBuilder.Entity("ITMCollegeService.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("AdminId")
                        .HasColumnType("int")
                        .HasColumnName("admin_id");

                    b.Property<DateTime?>("Created_At")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasColumnName("description");

                    b.Property<byte>("IsBanner")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint unsigned")
                        .HasColumnName("isBanner")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("name");

                    b.Property<byte>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint unsigned")
                        .HasColumnName("status")
                        .HasDefaultValueSql("((1))");

                    b.Property<DateTime?>("Updated_At")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "AdminId" }, "FKnews66529");

                    b.ToTable("news");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Previouseducation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("EnrollmentNumber")
                        .HasColumnType("int")
                        .HasColumnName("enrollmentNumber");

                    b.Property<string>("Faculty")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("faculty");

                    b.Property<float>("Gpa")
                        .HasColumnType("float")
                        .HasColumnName("gpa");

                    b.Property<string>("School")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("school");

                    b.HasKey("Id");

                    b.ToTable("previouseducation");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("role");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Semester", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("semester");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("status");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("date")
                        .HasColumnName("birthday");

                    b.Property<int?>("CollegeaddressId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Created_At")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int")
                        .HasColumnName("department_id");

                    b.Property<int?>("FacultyId")
                        .HasColumnType("int")
                        .HasColumnName("faculty_id");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("fatherName");

                    b.Property<int>("GenderId")
                        .HasColumnType("int")
                        .HasColumnName("gender_id");

                    b.Property<string>("MotherName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("motherName");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasColumnName("name");

                    b.Property<string>("PermanentAddress")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300) CHARACTER SET utf8mb4")
                        .HasColumnName("permanentAddress");

                    b.Property<int?>("PreviousEducationId")
                        .HasColumnType("int")
                        .HasColumnName("previousEducation_id");

                    b.Property<string>("ResidentialAddress")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300) CHARACTER SET utf8mb4")
                        .HasColumnName("residentialAddress");

                    b.Property<string>("SportsDetail")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250) CHARACTER SET utf8mb4")
                        .HasColumnName("sportsDetail");

                    b.Property<DateTime?>("Updated_At")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("CollegeaddressId");

                    b.HasIndex(new[] { "GenderId" }, "FKstudent120757");

                    b.HasIndex(new[] { "PreviousEducationId" }, "FKstudent463063");

                    b.HasIndex(new[] { "FacultyId" }, "FKstudent907803");

                    b.HasIndex(new[] { "DepartmentId" }, "department_id");

                    b.HasIndex(new[] { "UserId" }, "user_id")
                        .IsUnique();

                    b.ToTable("student");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("code");

                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("course_id");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CourseId" }, "FKsubject622011");

                    b.ToTable("subject");
                });

            modelBuilder.Entity("ITMCollegeService.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300) CHARACTER SET utf8mb4")
                        .HasColumnName("password");

                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("status_id");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250) CHARACTER SET utf8mb4")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "StatusId" }, "FKuser890583");

                    b.HasIndex(new[] { "Username" }, "username")
                        .IsUnique();

                    b.ToTable("user");
                });

            modelBuilder.Entity("ITMCollegeService.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "RoleId" }, "FKuser_role868982");

                    b.HasIndex(new[] { "UserId" }, "FKuser_role943458");

                    b.ToTable("user_role");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Admin", b =>
                {
                    b.HasOne("ITMCollegeService.Models.Gender", "Gender")
                        .WithMany("Admins")
                        .HasForeignKey("GenderId")
                        .HasConstraintName("FKadmin34186")
                        .IsRequired();

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("ITMCollegeService.Models.CategoryNews", b =>
                {
                    b.HasOne("ITMCollegeService.Models.Category", "Category")
                        .WithMany("CategoryNews")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FKcategory_n984463")
                        .IsRequired();

                    b.HasOne("ITMCollegeService.Models.News", "News")
                        .WithMany("CategoryNews")
                        .HasForeignKey("NewsId")
                        .HasConstraintName("FKcategory_n779857")
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("News");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Collegeaddress", b =>
                {
                    b.HasOne("ITMCollegeService.Models.College", "College")
                        .WithMany("Collegeaddresses")
                        .HasForeignKey("CollegeId")
                        .HasConstraintName("collegeaddress_ibfk_1");

                    b.Navigation("College");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Contact", b =>
                {
                    b.HasOne("ITMCollegeService.Models.Status", "Status")
                        .WithMany("Contacts")
                        .HasForeignKey("StatusId")
                        .HasConstraintName("FKcontact152934")
                        .IsRequired();

                    b.Navigation("Status");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Course", b =>
                {
                    b.HasOne("ITMCollegeService.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentId")
                        .HasConstraintName("FKcourse1975")
                        .IsRequired();

                    b.HasOne("ITMCollegeService.Models.Semester", "Semester")
                        .WithMany("Courses")
                        .HasForeignKey("SemesterId")
                        .HasConstraintName("FKcourse261733")
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Semester");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Department", b =>
                {
                    b.HasOne("ITMCollegeService.Models.Faculty", "Faculty")
                        .WithMany("Departments")
                        .HasForeignKey("FacultyId")
                        .HasConstraintName("FKdepartment546596")
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("ITMCollegeService.Models.News", b =>
                {
                    b.HasOne("ITMCollegeService.Models.Admin", "Admin")
                        .WithMany("News")
                        .HasForeignKey("AdminId")
                        .HasConstraintName("FKnews66529");

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Student", b =>
                {
                    b.HasOne("ITMCollegeService.Models.Collegeaddress", null)
                        .WithMany("Students")
                        .HasForeignKey("CollegeaddressId");

                    b.HasOne("ITMCollegeService.Models.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentId")
                        .HasConstraintName("student_ibfk_1");

                    b.HasOne("ITMCollegeService.Models.Faculty", "Faculty")
                        .WithMany("Students")
                        .HasForeignKey("FacultyId")
                        .HasConstraintName("FKstudent907803");

                    b.HasOne("ITMCollegeService.Models.Gender", "Gender")
                        .WithMany("Students")
                        .HasForeignKey("GenderId")
                        .HasConstraintName("FKstudent120757")
                        .IsRequired();

                    b.HasOne("ITMCollegeService.Models.Previouseducation", "PreviousEducation")
                        .WithMany("Students")
                        .HasForeignKey("PreviousEducationId")
                        .HasConstraintName("FKstudent463063");

                    b.HasOne("ITMCollegeService.Models.User", "User")
                        .WithOne("Student")
                        .HasForeignKey("ITMCollegeService.Models.Student", "UserId")
                        .HasConstraintName("FKstudent678198");

                    b.Navigation("Department");

                    b.Navigation("Faculty");

                    b.Navigation("Gender");

                    b.Navigation("PreviousEducation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Subject", b =>
                {
                    b.HasOne("ITMCollegeService.Models.Course", "Course")
                        .WithMany("Subjects")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FKsubject622011")
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("ITMCollegeService.Models.User", b =>
                {
                    b.HasOne("ITMCollegeService.Models.Status", "Status")
                        .WithMany("Users")
                        .HasForeignKey("StatusId")
                        .HasConstraintName("FKuser890583")
                        .IsRequired();

                    b.Navigation("Status");
                });

            modelBuilder.Entity("ITMCollegeService.Models.UserRole", b =>
                {
                    b.HasOne("ITMCollegeService.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FKuser_role868982")
                        .IsRequired();

                    b.HasOne("ITMCollegeService.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FKuser_role943458")
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Admin", b =>
                {
                    b.Navigation("News");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Category", b =>
                {
                    b.Navigation("CategoryNews");
                });

            modelBuilder.Entity("ITMCollegeService.Models.College", b =>
                {
                    b.Navigation("Collegeaddresses");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Collegeaddress", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Course", b =>
                {
                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Faculty", b =>
                {
                    b.Navigation("Departments");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Gender", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("ITMCollegeService.Models.News", b =>
                {
                    b.Navigation("CategoryNews");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Previouseducation", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Semester", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("ITMCollegeService.Models.Status", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ITMCollegeService.Models.User", b =>
                {
                    b.Navigation("Student");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
