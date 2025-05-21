using System;
using System.Collections.Generic;

namespace IndieGameDevelopmentHubApp.Models;

public partial class GameGenre
{
    public decimal GameId { get; set; }

    public string Genre { get; set; } = null!;

    public virtual Game Game { get; set; } = null!;
}
