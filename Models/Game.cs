using System;
using System.Collections.Generic;

namespace IndieGameDevelopmentHubApp.Models;

public partial class Game
{
    public decimal GameId { get; set; }

    public string Title { get; set; } = null!;

    public decimal GameRating { get; set; }

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();

    public virtual ICollection<BugReport> BugReports { get; set; } = new List<BugReport>();

    public virtual ICollection<GameGenre> GameGenres { get; set; } = new List<GameGenre>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual ICollection<TestersAccess> TestersAccesses { get; set; } = new List<TestersAccess>();

    public virtual ICollection<WorksOn> WorksOns { get; set; } = new List<WorksOn>();
}
