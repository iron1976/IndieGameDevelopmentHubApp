using System;
using System.Collections.Generic;

namespace IndieGameDevelopmentHubApp.Models;

public partial class DeveloperFinanceView
{
    public decimal DevId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public decimal? Income { get; set; }

    public decimal? RaiseRate { get; set; }
}
