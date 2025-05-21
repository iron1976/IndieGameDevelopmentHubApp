using System;
using System.Collections.Generic;

namespace IndieGameDevelopmentHubApp.Models;

public partial class WorksOn
{
    public decimal DevId { get; set; }

    public decimal GameId { get; set; }

    public string? Role { get; set; }

    public virtual Developer Dev { get; set; } = null!;

    public virtual Game Game { get; set; } = null!;
}
