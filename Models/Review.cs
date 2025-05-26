using System;
using System.Collections.Generic;

namespace IndieGameDevelopmentHubApp.Models;

public partial class Review
{
    public decimal ReviewId { get; set; }

    public decimal? PlayerId { get; set; }

    public decimal? GameId { get; set; }

    public string Review1 { get; set; } = null!;

    public decimal Rating { get; set; }

    public DateTime? ReviewDate { get; set; }

    public virtual Game? Game { get; set; }

    public virtual Player? Player { get; set; }
}
