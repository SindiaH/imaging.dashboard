﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Premedia.Applications.Imaging.Dashboard.Persistence;

#nullable disable

namespace Premedia.Applications.Imaging.Dashboard.Persistence.Migrations
{
    [DbContext(typeof(ImagingDashboardDbContext))]
    [Migration("20230707110355_AddedAttributes")]
    partial class AddedAttributes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Premedia.Applications.Imaging.Dashboard.Core.Entities.AdditionalFile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Filepath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AdditionalFile");
                });

            modelBuilder.Entity("Premedia.Applications.Imaging.Dashboard.Core.Entities.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shortcut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Premedia.Applications.Imaging.Dashboard.Core.Entities.FilePath", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("EbvFileaction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MacPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WindowsPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FilePath");
                });

            modelBuilder.Entity("Premedia.Applications.Imaging.Dashboard.Core.Entities.History", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ChangeTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EditorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ErrorCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OldValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EditorId");

                    b.ToTable("History");
                });

            modelBuilder.Entity("Premedia.Applications.Imaging.Dashboard.Core.Entities.Job", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AdditionalFileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ConsecutiveNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EasyJob")
                        .HasColumnType("bit");

                    b.Property<Guid?>("EditorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HistoriesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JobFilesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("JobInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Project")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SwitchJobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TimeTrackingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdditionalFileId");

                    b.HasIndex("CreatedById");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EditorId");

                    b.HasIndex("HistoriesId");

                    b.HasIndex("JobFilesId");

                    b.HasIndex("TimeTrackingId");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("Premedia.Applications.Imaging.Dashboard.Core.Entities.JobFiles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Activity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("EditedFilename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ErrorCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ErrorMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileProperties")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginalFilename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StorageType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SwitchJobField")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.ToTable("JobFiles");
                });

            modelBuilder.Entity("Premedia.Applications.Imaging.Dashboard.Core.Entities.TimeTracking", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EditorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartedOn")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("WorkingDuration")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("EditorId");

                    b.ToTable("TimeTracking");
                });

            modelBuilder.Entity("Premedia.Applications.Imaging.Dashboard.Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Premedia.Applications.Imaging.Dashboard.Core.Entities.History", b =>
                {
                    b.HasOne("Premedia.Applications.Imaging.Dashboard.Core.Entities.User", "Editor")
                        .WithMany()
                        .HasForeignKey("EditorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Editor");
                });

            modelBuilder.Entity("Premedia.Applications.Imaging.Dashboard.Core.Entities.Job", b =>
                {
                    b.HasOne("Premedia.Applications.Imaging.Dashboard.Core.Entities.AdditionalFile", "AdditionalFile")
                        .WithMany()
                        .HasForeignKey("AdditionalFileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Premedia.Applications.Imaging.Dashboard.Core.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Premedia.Applications.Imaging.Dashboard.Core.Entities.User", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Premedia.Applications.Imaging.Dashboard.Core.Entities.User", "Editor")
                        .WithMany()
                        .HasForeignKey("EditorId");

                    b.HasOne("Premedia.Applications.Imaging.Dashboard.Core.Entities.History", "Histories")
                        .WithMany()
                        .HasForeignKey("HistoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Premedia.Applications.Imaging.Dashboard.Core.Entities.JobFiles", "JobFiles")
                        .WithMany()
                        .HasForeignKey("JobFilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Premedia.Applications.Imaging.Dashboard.Core.Entities.TimeTracking", "TimeTracking")
                        .WithMany()
                        .HasForeignKey("TimeTrackingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdditionalFile");

                    b.Navigation("CreatedBy");

                    b.Navigation("Customer");

                    b.Navigation("Editor");

                    b.Navigation("Histories");

                    b.Navigation("JobFiles");

                    b.Navigation("TimeTracking");
                });

            modelBuilder.Entity("Premedia.Applications.Imaging.Dashboard.Core.Entities.JobFiles", b =>
                {
                    b.HasOne("Premedia.Applications.Imaging.Dashboard.Core.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");
                });

            modelBuilder.Entity("Premedia.Applications.Imaging.Dashboard.Core.Entities.TimeTracking", b =>
                {
                    b.HasOne("Premedia.Applications.Imaging.Dashboard.Core.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Premedia.Applications.Imaging.Dashboard.Core.Entities.User", "Editor")
                        .WithMany()
                        .HasForeignKey("EditorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("Editor");
                });
#pragma warning restore 612, 618
        }
    }
}
