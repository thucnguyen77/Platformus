﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Platformus.Barebone.Backend
{
  public class Option
  {
    public string Text { get; set; }
    public string Value { get; set; }

    public Option(string text = null, string value = null)
    {
      this.Text = text;
      this.Value = value;
    }
  }
}