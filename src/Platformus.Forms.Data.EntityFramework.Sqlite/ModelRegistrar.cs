﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ExtCore.Data.EntityFramework.Sqlite;
using Microsoft.EntityFrameworkCore;
using Platformus.Forms.Data.Models;

namespace Platformus.Forms.Data.EntityFramework.Sqlite
{
  public class ModelRegistrar : IModelRegistrar
  {
    public void RegisterModels(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<CachedForm>(etb =>
        {
          etb.HasKey(e => e.FormId);
          etb.Property(e => e.FormId);// .UseSqlServerIdentityColumn();
          etb.ForSqliteToTable("CachedForms");
        }
      );

      modelBuilder.Entity<Form>(etb =>
        {
          etb.HasKey(e => e.Id);
          etb.Property(e => e.Id);// .UseSqlServerIdentityColumn();
          etb.ForSqliteToTable("Forms");
        }
      );

      modelBuilder.Entity<FieldType>(etb =>
        {
          etb.HasKey(e => e.Id);
          etb.Property(e => e.Id);// .UseSqlServerIdentityColumn();
          etb.ForSqliteToTable("FieldTypes");
        }
      );

      modelBuilder.Entity<Field>(etb =>
        {
          etb.HasKey(e => e.Id);
          etb.Property(e => e.Id);// .UseSqlServerIdentityColumn();
          etb.ForSqliteToTable("Fields");
        }
      );

      modelBuilder.Entity<FieldOption>(etb =>
        {
          etb.HasKey(e => e.Id);
          etb.Property(e => e.Id);// .UseSqlServerIdentityColumn();
          etb.ForSqliteToTable("FieldOptions");
        }
      );
    }
  }
}