using System;
using System.Collections.Generic;

namespace IndieGameDevelopmentHubApp.Models;

public partial class DeveloperFinance
{
    public decimal DevId { get; set; }

    public decimal? Income { get; set; }

    public decimal? RaiseRate { get; set; }

    public virtual Developer Dev { get; set; } = null!;
}
