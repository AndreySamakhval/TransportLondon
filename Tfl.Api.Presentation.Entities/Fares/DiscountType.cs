﻿// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Fares.DiscountType
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.ComponentModel;

namespace Tfl.Api.Presentation.Entities.Fares
{
  public enum DiscountType
  {
    [Description("Not set")] NotSet,
    [Description("No Discount")] None,
    [Description("Bus and Tram")] BusTram,
    [Description("Job Centre")] JobCentre,
    [Description("Student")] Student,
    [Description("Apprentice")] Apprentice,
  }
}
