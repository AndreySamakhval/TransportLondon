// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Cabwise.Header
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities.Cabwise
{
  [DataContract(Name = "FindARide", Namespace = "")]
  public class Header
  {
    private DateTime publishDateTime;

    [DataMember]
    public string Identifier { get; set; }

    [DataMember]
    public string DisplayTitle { get; set; }

    [DataMember]
    public string Version { get; set; }

    [DataMember]
    public string PublishDateTime
    {
      get
      {
        return this.publishDateTime.ToString("MMM dd yyyy hh:mmtt");
      }
      set
      {
        this.publishDateTime = DateTime.Parse(value);
      }
    }

    [DataMember]
    public string CanonicalPublishDateTime
    {
      get
      {
        return this.publishDateTime.ToUniversalTime().ToString("MMM dd yyyy hh:mmtt");
      }
      set
      {
        this.publishDateTime = DateTime.Parse(value);
      }
    }

    [DataMember]
    public string Author { get; set; }

    [DataMember]
    public string Owner { get; set; }

    [DataMember]
    public int RefreshRate { get; set; }

    [DataMember]
    public int Max_Latency { get; set; }

    [DataMember]
    public int TimeToError { get; set; }

    [DataMember]
    public string Schedule { get; set; }

    [DataMember]
    public string Logo { get; set; }

    [DataMember]
    public string Language { get; set; }

    [DataMember]
    public Attribution Attribution { get; set; }

    public Header()
    {
      this.Identifier = "Licenced Private Hire Operators (Find a ride)";
      this.DisplayTitle = "Licenced Private Hire Operators (Find a ride)";
      this.Version = "0.1";
      this.publishDateTime = DateTime.Now;
      this.Author = "webteam@tfl.gov.uk";
      this.Owner = "Transport for London";
      this.RefreshRate = 720;
      this.Max_Latency = 10;
      this.TimeToError = 20;
      this.Schedule = "Twice a day at 02:00 and 14:00";
      this.Logo = "http://www.tfl.gov.uk/tfl-global/images/roundel.gif";
      this.Language = "en";
      this.Attribution = new Attribution();
    }
  }
}
