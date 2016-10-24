// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.EtlRequest
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System;
namespace Tfl.Api.Presentation.Entities
{
  public class EtlRequest
  {
    public int Id { get; set; }

    public string TaskName { get; set; }

    public string Status { get; set; }

    public string ResultText { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public DateTime? Started { get; set; }

    public DateTime? Completed { get; set; }

    public long? SsisExecutionId { get; set; }

    public string SubTaskStatus { get; set; }

    public string SubTaskResult { get; set; }

    public string CreatedBy { get; set; }

  //  public ETLRequestType RequestType { get; set; }

    public TimeSpan ExpectedCompletionTime { get; set; }
  }
}
