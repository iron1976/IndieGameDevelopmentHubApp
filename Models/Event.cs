using System;
using System.Collections.Generic;

namespace IndieGameDevelopmentHubApp.Models;

public partial class Event
{
    public decimal EventId { get; set; }

    public string? Description { get; set; }

    public DateTime EventStartDate { get; set; }

    public DateTime EventEndDate { get; set; }
}
