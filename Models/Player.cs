using System;
using System.Collections.Generic;

namespace IndieGameDevelopmentHubApp.Models;

public partial class Player
{
    public decimal PlayerId { get; set; }

    public string PlayerName { get; set; } = null!;

    public DateTime RegisterDate { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
