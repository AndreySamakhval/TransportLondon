﻿// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.WebCAT.WebCatLocationInformation
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

namespace Tfl.Api.Presentation.Entities.WebCAT
{
  public class WebCatLocationInformation
  {
    public double Lat { get; set; }

    public double Lon { get; set; }

    public string Borough { get; set; }

    public bool InsideGla { get; set; }

    public double Easting { get; set; }

    public double Northing { get; set; }

    public string Address { get; set; }

    public string Name { get; set; }

    public string PlaceId { get; set; }
  }
}
