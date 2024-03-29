﻿// <auto-generated />
using System;
using M.Model.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace M.Model.Migrations
{
    [DbContext(typeof(FangHuaHostDbContext))]
    [Migration("20200319151155_Add_Table_DevLoveInfo")]
    partial class Add_Table_DevLoveInfo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("M.Model.Entity.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminName");

                    b.Property<string>("AdminPwd");

                    b.HasKey("Id");

                    b.ToTable("Admin");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdminName = "admin",
                            AdminPwd = "123456"
                        },
                        new
                        {
                            Id = 2,
                            AdminName = "Mr.Fang",
                            AdminPwd = "Fh2269..."
                        });
                });

            modelBuilder.Entity("M.Model.Entity.DevLoveInfo", b =>
                {
                    b.Property<int>("DLId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("DLDay")
                        .IsRequired();

                    b.Property<string>("DLInfo")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("DLMonth")
                        .IsRequired();

                    b.Property<string>("DLName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("DLQQ")
                        .IsRequired();

                    b.Property<string>("DLYear")
                        .IsRequired();

                    b.Property<string>("DLoveInfo")
                        .HasMaxLength(10);

                    b.Property<string>("DLoveName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("IsDeleted");

                    b.HasKey("DLId");

                    b.ToTable("DevLoveInfo");

                    b.HasData(
                        new
                        {
                            DLId = 1,
                            CreateTime = new DateTime(2020, 3, 19, 23, 11, 55, 572, DateTimeKind.Local).AddTicks(1076),
                            DLDay = "6",
                            DLInfo = "希望以后和你的生活，温柔，有趣，不必太激烈，三餐，四季，不必太匆忙，毕竟我有一生的时间要和你浪费。",
                            DLMonth = "3",
                            DLName = "Mr.Fang",
                            DLQQ = "2875616188",
                            DLYear = "2017",
                            DLoveInfo = "我永远在！",
                            DLoveName = "文洁",
                            IsDeleted = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
