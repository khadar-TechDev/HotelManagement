using System;
using System.Collections.Generic;

namespace HotelManagement.Server.Repository.Models;

public partial class Signup
{
    public string? Name { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public int? SubscriptionTenureId { get; set; }

    public int? HotelId { get; set; }

    public int? SignupStatusId { get; set; }

    public virtual Hotel? Hotel { get; set; }

    public virtual SignupStatus? SignupStatus { get; set; }

    public virtual SubscriptionTenure? SubscriptionTenure { get; set; }
}
