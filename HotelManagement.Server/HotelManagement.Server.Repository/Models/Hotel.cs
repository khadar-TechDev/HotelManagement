using System;
using System.Collections.Generic;

namespace HotelManagement.Server.Repository.Models;

public partial class Hotel
{
    public int HotelId { get; set; }

    public string? HotelName { get; set; }

    public string? HotelAddress { get; set; }
}
