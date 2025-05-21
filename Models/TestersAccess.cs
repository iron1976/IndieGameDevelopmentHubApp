using System;
using System.Collections.Generic;

namespace IndieGameDevelopmentHubApp.Models;

public partial class TestersAccess
{
    public decimal GameId { get; set; }

    public decimal TesterId { get; set; }

    public bool IsAllowed { get; set; }

    public virtual Game Game { get; set; } = null!;

    public virtual Tester Tester { get; set; } = null!;
}
