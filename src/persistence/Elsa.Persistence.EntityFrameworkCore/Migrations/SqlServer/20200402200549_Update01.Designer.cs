﻿// <auto-generated />
using System;
using Elsa.Persistence.EntityFrameworkCore.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Elsa.Persistence.EntityFrameworkCore.Migrations.SqlServer
{
    [DbContext(typeof(SqlServerContext))]
    [Migration("20200402200549_Update01")]
    partial class Update01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.ActivityDefinitionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivityId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Left")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Top")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkflowDefinitionVersionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowDefinitionVersionId");

                    b.ToTable("ActivityDefinitions");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.ActivityInstanceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivityId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Output")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkflowInstanceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowInstanceId");

                    b.ToTable("ActivityInstances");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.BlockingActivityEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivityId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActivityType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkflowInstanceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowInstanceId");

                    b.ToTable("BlockingActivities");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.ConnectionDefinitionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DestinationActivityId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Outcome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SourceActivityId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkflowDefinitionVersionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowDefinitionVersionId");

                    b.ToTable("ConnectionDefinitions");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.WorkflowDefinitionVersionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DefinitionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLatest")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSingleton")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Variables")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.Property<string>("VersionId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkflowDefinitionVersions");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.WorkflowInstanceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AbortedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CorrelationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DefinitionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExecutionLog")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fault")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FaultedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FinishedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Input")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstanceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Scopes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WorkflowInstances");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.ActivityDefinitionEntity", b =>
                {
                    b.HasOne("Elsa.Persistence.EntityFrameworkCore.Entities.WorkflowDefinitionVersionEntity", "WorkflowDefinitionVersion")
                        .WithMany("Activities")
                        .HasForeignKey("WorkflowDefinitionVersionId");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.ActivityInstanceEntity", b =>
                {
                    b.HasOne("Elsa.Persistence.EntityFrameworkCore.Entities.WorkflowInstanceEntity", "WorkflowInstance")
                        .WithMany("Activities")
                        .HasForeignKey("WorkflowInstanceId");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.BlockingActivityEntity", b =>
                {
                    b.HasOne("Elsa.Persistence.EntityFrameworkCore.Entities.WorkflowInstanceEntity", "WorkflowInstance")
                        .WithMany("BlockingActivities")
                        .HasForeignKey("WorkflowInstanceId");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.ConnectionDefinitionEntity", b =>
                {
                    b.HasOne("Elsa.Persistence.EntityFrameworkCore.Entities.WorkflowDefinitionVersionEntity", "WorkflowDefinitionVersion")
                        .WithMany("Connections")
                        .HasForeignKey("WorkflowDefinitionVersionId");
                });
#pragma warning restore 612, 618
        }
    }
}
