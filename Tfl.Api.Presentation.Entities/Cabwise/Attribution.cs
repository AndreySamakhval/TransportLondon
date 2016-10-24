// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Cabwise.Attribution
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities.Cabwise
{
  [DataContract(Namespace = "")]
  public class Attribution
  {
    [DataMember]
    public string Link { get; set; }

    [DataMember]
    public string Text { get; set; }

    [DataMember]
    public string Logo { get; set; }

    public Attribution()
    {
      this.Link = "http://www.tfl.gov.uk/";
      this.Text = "© TfL";
      this.Logo = "http://www.tfl.gov.uk/tfl-global/images/roundel.gif";
    }
  }
}
