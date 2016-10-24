// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.RoadProject
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract(IsReference = true)]
  public class RoadProject
  {
    [DataMember]
    public string ProjectId { get; set; }

    [DataMember]
    public string SchemeName { get; set; }

    [DataMember]
    public string ProjectName { get; set; }

    [DataMember]
    public string ProjectDescription { get; set; }

    [DataMember]
    public string ProjectPageUrl { get; set; }

    [DataMember]
    public string ConsultationPageUrl { get; set; }

    [DataMember]
    public DateTime ConsultationStartDate { get; set; }

    [DataMember]
    public DateTime ConsultationEndDate { get; set; }

    [DataMember]
    public DateTime ConstructionStartDate { get; set; }

    [DataMember]
    public DateTime ConstructionEndDate { get; set; }

    [DataMember]
    public List<string> BoroughsBenefited { get; set; }

    [DataMember]
    public string CycleSuperhighwayId { get; set; }

    [DataMember]
    public ProjectPhaseEnum Phase { get; set; }

    [DataMember]
    public string ContactName { get; set; }

    [DataMember]
    public string ContactEmail { get; set; }

    [DataMember]
    public string ExternalPageUrl { get; set; }

    [DataMember]
    public string ProjectSummaryPageUrl { get; set; }
  }
}
