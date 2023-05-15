﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SignalRChatTemplete.DBContexts.EFCore;

#nullable disable

namespace SignalRTemplete.DBContexts.EFCore.Migrations
{
    [DbContext(typeof(ProjectDBContext_SignalR))]
    partial class ProjectDBContext_SignalRModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SignalRChatTemplete.Models.Entities.ChatRecord", b =>
                {
                    b.Property<int>("SerialNum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SerialNum"));

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("GroupID")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("SerialNum");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("SerialNum"), false);

                    b.HasIndex("CreateOn")
                        .HasDatabaseName("IX_ChatRecord_CreateOn");

                    SqlServerIndexBuilderExtensions.IsClustered(b.HasIndex("CreateOn"));

                    b.HasIndex("GroupID")
                        .HasDatabaseName("IX_ChatRecord_GroupID");

                    SqlServerIndexBuilderExtensions.IsClustered(b.HasIndex("GroupID"), false);

                    b.HasIndex("UserID")
                        .HasDatabaseName("IX_ChatRecord_UserID");

                    SqlServerIndexBuilderExtensions.IsClustered(b.HasIndex("UserID"), false);

                    b.ToTable("ChatRecord");
                });

            modelBuilder.Entity("SignalRChatTemplete.Models.Entities.GroupInfo", b =>
                {
                    b.Property<int>("GroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupID"));

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsEnable")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int?>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateOn")
                        .HasColumnType("datetime2");

                    b.HasKey("GroupID");

                    b.HasIndex("CreateOn")
                        .HasDatabaseName("IX_GroupInfo_CreateOn");

                    SqlServerIndexBuilderExtensions.IsClustered(b.HasIndex("CreateOn"), false);

                    b.HasIndex("GroupName")
                        .HasDatabaseName("IX_GroupInfo_GroupName");

                    SqlServerIndexBuilderExtensions.IsClustered(b.HasIndex("GroupName"), false);

                    b.HasIndex("IsEnable")
                        .HasDatabaseName("IX_GroupInfo_IsEnable");

                    SqlServerIndexBuilderExtensions.IsClustered(b.HasIndex("IsEnable"), false);

                    b.HasIndex("UpdateOn")
                        .HasDatabaseName("IX_GroupInfo_UpdateOn");

                    SqlServerIndexBuilderExtensions.IsClustered(b.HasIndex("UpdateOn"), false);

                    b.ToTable("GroupInfo");
                });

            modelBuilder.Entity("SignalRChatTemplete.Models.Entities.UserGroupInfo", b =>
                {
                    b.Property<int>("UserInfoSerialNum")
                        .HasColumnType("int");

                    b.Property<int>("GroupID")
                        .HasColumnType("int");

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsValid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int?>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateOn")
                        .HasColumnType("datetime2");

                    b.HasKey("UserInfoSerialNum", "GroupID");

                    b.ToTable("UserGroupInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
