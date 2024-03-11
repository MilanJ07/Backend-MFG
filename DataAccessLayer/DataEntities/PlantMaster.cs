using System;
using System.Collections.Generic;

namespace DataAccessLayer.DataEntities;

public partial class PlantMaster
{
    public decimal Id { get; set; }

    public string? PlantCode { get; set; }

    public string? LocationId { get; set; }

    public string? PlantDesc { get; set; }

    public string? PlantAddress { get; set; }

    public string? City { get; set; }

    public string? StateCode { get; set; }

    public string? CountryCode { get; set; }

    public string? PostalCode { get; set; }

    public string? PanNo { get; set; }

    public string? GstnNo { get; set; }

    public string? AuCode { get; set; }

    public string? PlantType { get; set; }

    public string? SiteCode { get; set; }

    public string? Dsc { get; set; }

    public string? Dcp { get; set; }

    public string? TransactionType { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ExtraAttr1 { get; set; }

    public string? ExtraAttr2 { get; set; }

    public string? ExtraAttr3 { get; set; }

    public string? ExtraAttr4 { get; set; }

    public string? ExtraAttr5 { get; set; }

    public string? ExtraAttr6 { get; set; }

    public string? ExtraAttr7 { get; set; }

    public string? ExtraAttr8 { get; set; }

    public string? ExtraAttr9 { get; set; }

    public string? ExtraAttr10 { get; set; }
}
