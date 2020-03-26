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
    [DbContext(typeof(MChenVipDbContext))]
    [Migration("20200325121144_Add_Table_CopywritingInfo")]
    partial class Add_Table_CopywritingInfo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("M.Model.Entity.AccessHistoryLog", b =>
                {
                    b.Property<int>("AHId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("DeviceInfo")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("IsDeleted");

                    b.Property<string>("Url")
                        .IsRequired();

                    b.HasKey("AHId");

                    b.ToTable("AccessHistoryLog");
                });

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

            modelBuilder.Entity("M.Model.Entity.BackGroundImageInfo", b =>
                {
                    b.Property<int>("BGId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BGUrl");

                    b.HasKey("BGId");

                    b.ToTable("BackGroundImageInfo");

                    b.HasData(
                        new
                        {
                            BGId = 1,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg1"
                        },
                        new
                        {
                            BGId = 2,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg2"
                        },
                        new
                        {
                            BGId = 3,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg3"
                        },
                        new
                        {
                            BGId = 4,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg4"
                        },
                        new
                        {
                            BGId = 5,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg5"
                        },
                        new
                        {
                            BGId = 6,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg6"
                        },
                        new
                        {
                            BGId = 7,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg7"
                        },
                        new
                        {
                            BGId = 8,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg8"
                        },
                        new
                        {
                            BGId = 9,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg9"
                        },
                        new
                        {
                            BGId = 10,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg10"
                        },
                        new
                        {
                            BGId = 11,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg11"
                        },
                        new
                        {
                            BGId = 12,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg12"
                        },
                        new
                        {
                            BGId = 13,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg13"
                        },
                        new
                        {
                            BGId = 14,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg14"
                        },
                        new
                        {
                            BGId = 15,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg15"
                        },
                        new
                        {
                            BGId = 16,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg16"
                        },
                        new
                        {
                            BGId = 17,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg17"
                        },
                        new
                        {
                            BGId = 18,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg18"
                        },
                        new
                        {
                            BGId = 19,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg19"
                        },
                        new
                        {
                            BGId = 20,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg20"
                        },
                        new
                        {
                            BGId = 21,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg21"
                        },
                        new
                        {
                            BGId = 22,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg22"
                        },
                        new
                        {
                            BGId = 23,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg23"
                        },
                        new
                        {
                            BGId = 24,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg24"
                        },
                        new
                        {
                            BGId = 25,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg25"
                        },
                        new
                        {
                            BGId = 26,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg26"
                        },
                        new
                        {
                            BGId = 27,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg27"
                        },
                        new
                        {
                            BGId = 28,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg28"
                        },
                        new
                        {
                            BGId = 29,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg29"
                        },
                        new
                        {
                            BGId = 30,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg30"
                        },
                        new
                        {
                            BGId = 31,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg31"
                        },
                        new
                        {
                            BGId = 32,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg32"
                        },
                        new
                        {
                            BGId = 33,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg33"
                        },
                        new
                        {
                            BGId = 34,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg34"
                        },
                        new
                        {
                            BGId = 35,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg35"
                        },
                        new
                        {
                            BGId = 36,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg36"
                        },
                        new
                        {
                            BGId = 37,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg37"
                        },
                        new
                        {
                            BGId = 38,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg38"
                        },
                        new
                        {
                            BGId = 39,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg39"
                        },
                        new
                        {
                            BGId = 40,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg40"
                        },
                        new
                        {
                            BGId = 41,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg41"
                        },
                        new
                        {
                            BGId = 42,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg42"
                        },
                        new
                        {
                            BGId = 43,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg43"
                        },
                        new
                        {
                            BGId = 44,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg44"
                        },
                        new
                        {
                            BGId = 45,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg45"
                        },
                        new
                        {
                            BGId = 46,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg46"
                        },
                        new
                        {
                            BGId = 47,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg47"
                        },
                        new
                        {
                            BGId = 48,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg48"
                        },
                        new
                        {
                            BGId = 49,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg49"
                        },
                        new
                        {
                            BGId = 50,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg50"
                        },
                        new
                        {
                            BGId = 51,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg51"
                        },
                        new
                        {
                            BGId = 52,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg52"
                        },
                        new
                        {
                            BGId = 53,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg53"
                        },
                        new
                        {
                            BGId = 54,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg54"
                        },
                        new
                        {
                            BGId = 55,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg55"
                        },
                        new
                        {
                            BGId = 56,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg56"
                        },
                        new
                        {
                            BGId = 57,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg57"
                        },
                        new
                        {
                            BGId = 58,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg58"
                        },
                        new
                        {
                            BGId = 59,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg59"
                        },
                        new
                        {
                            BGId = 60,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg60"
                        },
                        new
                        {
                            BGId = 61,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg61"
                        },
                        new
                        {
                            BGId = 62,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg62"
                        },
                        new
                        {
                            BGId = 63,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg63"
                        },
                        new
                        {
                            BGId = 64,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg64"
                        },
                        new
                        {
                            BGId = 65,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg65"
                        },
                        new
                        {
                            BGId = 66,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg66"
                        },
                        new
                        {
                            BGId = 67,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg67"
                        },
                        new
                        {
                            BGId = 68,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg68"
                        },
                        new
                        {
                            BGId = 69,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg69"
                        },
                        new
                        {
                            BGId = 70,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg70"
                        },
                        new
                        {
                            BGId = 71,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg71"
                        },
                        new
                        {
                            BGId = 72,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg72"
                        },
                        new
                        {
                            BGId = 73,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg73"
                        },
                        new
                        {
                            BGId = 74,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg74"
                        },
                        new
                        {
                            BGId = 75,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg75"
                        },
                        new
                        {
                            BGId = 76,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg76"
                        },
                        new
                        {
                            BGId = 77,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg77"
                        },
                        new
                        {
                            BGId = 78,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg78"
                        },
                        new
                        {
                            BGId = 79,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg79"
                        },
                        new
                        {
                            BGId = 80,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg80"
                        },
                        new
                        {
                            BGId = 81,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg81"
                        },
                        new
                        {
                            BGId = 82,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg82"
                        },
                        new
                        {
                            BGId = 83,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg83"
                        },
                        new
                        {
                            BGId = 84,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg84"
                        },
                        new
                        {
                            BGId = 85,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg85"
                        },
                        new
                        {
                            BGId = 86,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg86"
                        },
                        new
                        {
                            BGId = 87,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg87"
                        },
                        new
                        {
                            BGId = 88,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg88"
                        },
                        new
                        {
                            BGId = 89,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg89"
                        },
                        new
                        {
                            BGId = 90,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg90"
                        },
                        new
                        {
                            BGId = 91,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg91"
                        },
                        new
                        {
                            BGId = 92,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg92"
                        },
                        new
                        {
                            BGId = 93,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg93"
                        },
                        new
                        {
                            BGId = 94,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg94"
                        },
                        new
                        {
                            BGId = 95,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg95"
                        },
                        new
                        {
                            BGId = 96,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg96"
                        },
                        new
                        {
                            BGId = 97,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg97"
                        },
                        new
                        {
                            BGId = 98,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg98"
                        },
                        new
                        {
                            BGId = 99,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg99"
                        },
                        new
                        {
                            BGId = 100,
                            BGUrl = "http://mchen.vip/accsets/images/background/bg100"
                        });
                });

            modelBuilder.Entity("M.Model.Entity.CopywritingInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("IsDeleted");

                    b.HasKey("Id");

                    b.ToTable("CopywritingInfo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "当你的能力还撑不起你的野心的时，你就需要静下心来 好好学习。",
                            CreateTime = new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(6043),
                            IsDeleted = 0
                        },
                        new
                        {
                            Id = 2,
                            Content = "脏的人多了，干净反倒成了一种错。",
                            CreateTime = new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(6774),
                            IsDeleted = 0
                        },
                        new
                        {
                            Id = 3,
                            Content = "你羡慕的生活都是你没熬过的苦。",
                            CreateTime = new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(6781),
                            IsDeleted = 0
                        },
                        new
                        {
                            Id = 4,
                            Content = "所谓天才，只不过是把别人喝咖啡的功夫都用在了工作上了。",
                            CreateTime = new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(6782),
                            IsDeleted = 0
                        },
                        new
                        {
                            Id = 5,
                            Content = "生活便是寻求新的知识。——门捷列夫",
                            CreateTime = new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(6782),
                            IsDeleted = 0
                        },
                        new
                        {
                            Id = 6,
                            Content = "如果你浪费了自己的年龄，那是挺可悲的。因为你的青春只能持续一点儿时间——很短的一点儿时间。",
                            CreateTime = new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(6783),
                            IsDeleted = 0
                        },
                        new
                        {
                            Id = 7,
                            Content = "世界上一成不变的东西，只有“任何事物都是在不断变化的”这条真理。",
                            CreateTime = new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(6784),
                            IsDeleted = 0
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
                            CreateTime = new DateTime(2020, 3, 25, 20, 11, 43, 958, DateTimeKind.Local).AddTicks(1792),
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

            modelBuilder.Entity("M.Model.Entity.EmailHistoryInfo", b =>
                {
                    b.Property<int>("EHID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("EmailBody")
                        .IsRequired();

                    b.Property<int>("IsDeleted");

                    b.Property<string>("RecipientId")
                        .IsRequired();

                    b.HasKey("EHID");

                    b.ToTable("EmailHistoryInfo");
                });

            modelBuilder.Entity("M.Model.Entity.GuidePagesMenuInfo", b =>
                {
                    b.Property<int>("MenuID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("IsDeleted");

                    b.Property<string>("MenuName")
                        .IsRequired();

                    b.Property<int>("MenuOrder");

                    b.Property<string>("MenuUrl")
                        .IsRequired();

                    b.Property<int>("ParentId");

                    b.HasKey("MenuID");

                    b.ToTable("GuidePagesMenuInfo");

                    b.HasData(
                        new
                        {
                            MenuID = 1,
                            CreateTime = new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(1680),
                            IsDeleted = 0,
                            MenuName = "首页",
                            MenuOrder = 1,
                            MenuUrl = "http://home.mchen.vip",
                            ParentId = 0
                        },
                        new
                        {
                            MenuID = 2,
                            CreateTime = new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(3034),
                            IsDeleted = 0,
                            MenuName = "Mr.Fang♥Mrs.Zhou",
                            MenuOrder = 2,
                            MenuUrl = "http://fh.mchen.vip",
                            ParentId = 0
                        },
                        new
                        {
                            MenuID = 3,
                            CreateTime = new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(3048),
                            IsDeleted = 0,
                            MenuName = "QQ",
                            MenuOrder = 3,
                            MenuUrl = "https://wpa.qq.com/msgrd?v=3&uin=2875616188&site=qq&menu=yes",
                            ParentId = 0
                        },
                        new
                        {
                            MenuID = 4,
                            CreateTime = new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(3049),
                            IsDeleted = 0,
                            MenuName = "微信",
                            MenuOrder = 4,
                            MenuUrl = "http://mchen.vip/accsets/images/weixin.jpg",
                            ParentId = 0
                        },
                        new
                        {
                            MenuID = 5,
                            CreateTime = new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(3050),
                            IsDeleted = 0,
                            MenuName = "表白小工具",
                            MenuOrder = 5,
                            MenuUrl = "http://devlove.mchen.vip",
                            ParentId = 0
                        },
                        new
                        {
                            MenuID = 6,
                            CreateTime = new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(3050),
                            IsDeleted = 0,
                            MenuName = "实用小工具",
                            MenuOrder = 6,
                            MenuUrl = "http://tool.mchen.vip",
                            ParentId = 0
                        },
                        new
                        {
                            MenuID = 7,
                            CreateTime = new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(3051),
                            IsDeleted = 0,
                            MenuName = "休闲小游戏",
                            MenuOrder = 7,
                            MenuUrl = "http://game.mchen.vip",
                            ParentId = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}