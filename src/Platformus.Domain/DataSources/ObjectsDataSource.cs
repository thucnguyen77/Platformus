﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using Platformus.Domain.Data.Abstractions;
using Platformus.Domain.Data.Models;
using Platformus.Globalization;

namespace Platformus.Domain.DataSources
{
  public class ObjectsDataSource : DataSourceBase
  {
    public override IEnumerable<Object> GetObjects()
    {
      return this.requestHandler.Storage.GetRepository<IObjectRepository>().All().Where(o => o.ClassId == int.Parse(this.args["ClassId"]));
    }

    public override IEnumerable<CachedObject> GetCachedObjects()
    {
      return this.requestHandler.Storage.GetRepository<ICachedObjectRepository>().FilteredByCultureId(CultureManager.GetCurrentCulture(this.requestHandler.Storage).Id).Where(o => o.ClassId == int.Parse(this.args["ClassId"]));
    }
  }
}