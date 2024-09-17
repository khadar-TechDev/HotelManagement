using System;
using System.Collections.Generic;

namespace HotelManagement.Server.Repository.Models;

public partial class SignupStatus
{
    public int SignupStatusId { get; set; }

    public string? SignupStatusDescription { get; set; }
}
