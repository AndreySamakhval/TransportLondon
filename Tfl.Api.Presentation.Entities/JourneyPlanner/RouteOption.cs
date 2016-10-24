// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.JourneyPlanner.RouteOption
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Serialization;

namespace Tfl.Api.Presentation.Entities.JourneyPlanner
{
  public class RouteOption : IIdentifiable
  {
    public string Id { get; set; }

    [XmlAttribute("Name")]
    public string Name { get; set; }

    [XmlElement("Directions")]
    public IEnumerable<string> Directions { get; set; }

    public Identifier LineIdentifier { get; set; }

    public RouteOption()
    {
      this.Directions = (IEnumerable<string>) new List<string>();
    }

    public RouteOption(string name, IEnumerable<string> directions)
    {
      this.Name = name;
      this.Directions = directions;
    }

    public RouteOption(string Id, string name, IEnumerable<string> directions, string lineStatus, string lineStatusDetail)
    {
      this.Id = Id;
      this.Name = name;
      this.Directions = directions;
    }

    public Identifier ToIdentifier()
    {
      return new Identifier()
      {
        Id = this.Id.ToString((IFormatProvider) CultureInfo.InvariantCulture),
        Name = this.Name,
        Type = typeof (RouteOption).Name,
        Uri = string.Format("/RouteOption/{0}", (object) this.Id)
      };
    }
  }
}
