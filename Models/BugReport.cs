using System;
using System.Collections.Generic;

namespace IndieGameDevelopmentHubApp.Models;

public partial class BugReport
{
    public decimal ReportId { get; set; }

    public decimal GameId { get; set; }

    public decimal? TesterId { get; set; }

    public string? Report { get; set; }

    public virtual Game Game { get; set; } = null!;

    public virtual Tester? Tester { get; set; }
}
