using System;
using System.Collections.Generic;

namespace HotelManagement.Server.Repository.Models;

public partial class SubscriptionTenure
{
    public int SubscriptionTenureId { get; set; }

    public int? SubscriptionTenurePeriod { get; set; }

    public string? SubscriptionTenureDescription { get; set; }
}
