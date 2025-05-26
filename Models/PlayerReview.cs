using System;
using System.Collections.Generic;

namespace IndieGameDevelopmentHubApp.Models;

public partial class PlayerReview
{
    public string FirstName { get; set; } = null!;

    public string GameTitle { get; set; } = null!;

    public string Review { get; set; } = null!;

    public decimal Rating { get; set; }

    public DateTime? ReviewDate { get; set; }
}
