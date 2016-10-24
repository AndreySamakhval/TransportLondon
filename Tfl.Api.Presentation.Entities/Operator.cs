// Decompiled with JetBrains decompiler
// Type: Tfl.Api.Presentation.Entities.Operator
// Assembly: Tfl.Api.Presentation.Entities, Version=5.2.1.207, Culture=neutral, PublicKeyToken=null
// MVID: E59B4B31-944D-4B98-B8F9-899DD93EF2F1
// Assembly location: G:\Downloads\DTOs\Tfl.Api.Presentation.Entities.dll

using System.Runtime.Serialization;

namespace Tfl.Api.Presentation.Entities
{
  [DataContract(Namespace = "")]
  public class Operator
  {
    [DataMember]
    public int? OperatorId { get; set; }

    [DataMember]
    public string OrganisationName { get; set; }

    [DataMember]
    public string TradingName { get; set; }

    [DataMember]
    public TradingNames AlsoKnownAs { get; set; }

    [DataMember]
    public int CentreId { get; set; }

    [DataMember]
    public string AddressLine1 { get; set; }

    [DataMember]
    public string AddressLine2 { get; set; }

    [DataMember]
    public string AddressLine3 { get; set; }

    [DataMember]
    public string Town { get; set; }

    [DataMember]
    public string County { get; set; }

    [DataMember]
    public string Postcode { get; set; }

    [DataMember]
    public string BookingsPhoneNumber { get; set; }

    [DataMember]
    public string BookingsEmail { get; set; }

    [DataMember]
    public bool? PublicAccess { get; set; }

    [DataMember]
    public bool? PublicWaitingRoom { get; set; }

    [DataMember]
    public bool? WheelchairAccessible { get; set; }

    [DataMember]
    public bool? CreditDebitCard { get; set; }

    [DataMember]
    public bool? ChequeBankersCard { get; set; }

    [DataMember]
    public bool? AccountServicesAvailable { get; set; }

    [DataMember]
    public bool? HoursOfOperation24X7 { get; set; }

    [DataMember]
    public bool? HoursOfOperationMonThu { get; set; }

    [DataMember]
    public string StartTimeMonThu { get; set; }

    [DataMember]
    public string EndTimeMonThu { get; set; }

    [DataMember]
    public bool? HoursOfOperationFri { get; set; }

    [DataMember]
    public string StartTimeFri { get; set; }

    [DataMember]
    public string EndTimeFri { get; set; }

    [DataMember]
    public bool? HoursOfOperationSat { get; set; }

    [DataMember]
    public string StartTimeSat { get; set; }

    [DataMember]
    public string EndTimeSat { get; set; }

    [DataMember]
    public bool? HoursOfOperationSun { get; set; }

    [DataMember]
    public string StartTimeSun { get; set; }

    [DataMember]
    public string EndTimeSun { get; set; }

    [DataMember]
    public bool? HoursOfOperationPubHol { get; set; }

    [DataMember]
    public string StartTimePubHol { get; set; }

    [DataMember]
    public string EndTimePubHol { get; set; }

    [DataMember]
    public int? NumberOfVehicles { get; set; }

    [DataMember]
    public int? NumberOfVehiclesWheelchair { get; set; }

    [DataMember]
    public double? Longitude { get; set; }

    [DataMember]
    public double? Latitude { get; set; }

    [DataMember]
    public OperatorTypes OperatorTypes { get; set; }

    [DataMember]
    public double? Distance { get; set; }

    public Operator()
    {
      this.CentreId = 0;
      this.OperatorId = new int?(0);
      this.OrganisationName = string.Empty;
      this.TradingName = string.Empty;
      this.AlsoKnownAs = new TradingNames();
      this.AddressLine1 = string.Empty;
      this.AddressLine2 = string.Empty;
      this.AddressLine3 = string.Empty;
      this.Town = string.Empty;
      this.County = string.Empty;
      this.Postcode = string.Empty;
      this.BookingsPhoneNumber = string.Empty;
      this.BookingsEmail = string.Empty;
      this.PublicAccess = new bool?(false);
      this.PublicWaitingRoom = new bool?(false);
      this.WheelchairAccessible = new bool?(false);
      this.CreditDebitCard = new bool?(false);
      this.ChequeBankersCard = new bool?(false);
      this.AccountServicesAvailable = new bool?(false);
      this.HoursOfOperation24X7 = new bool?(false);
      this.HoursOfOperationMonThu = new bool?(false);
      this.StartTimeMonThu = string.Empty;
      this.EndTimeMonThu = string.Empty;
      this.HoursOfOperationFri = new bool?(false);
      this.StartTimeFri = string.Empty;
      this.EndTimeFri = string.Empty;
      this.HoursOfOperationSat = new bool?(false);
      this.StartTimeSat = string.Empty;
      this.EndTimeSat = string.Empty;
      this.HoursOfOperationSun = new bool?(false);
      this.StartTimeSun = string.Empty;
      this.EndTimeSun = string.Empty;
      this.HoursOfOperationPubHol = new bool?(false);
      this.StartTimePubHol = string.Empty;
      this.EndTimePubHol = string.Empty;
      this.NumberOfVehicles = new int?(0);
      this.NumberOfVehiclesWheelchair = new int?(0);
      this.Latitude = new double?(0.0);
      this.Longitude = new double?(0.0);
      this.OperatorTypes = new OperatorTypes();
    }
  }
}
