using System;
using System.Collections.Generic;

namespace IndieGameDevelopmentHubApp.Models;

public partial class Developer
{
    public decimal DevId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime? RegisterDate { get; set; }

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();

    public virtual DeveloperFinance? DeveloperFinance { get; set; }

    public virtual ICollection<WorksOn> WorksOns { get; set; } = new List<WorksOn>();
}
