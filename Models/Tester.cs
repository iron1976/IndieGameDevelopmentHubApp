using System;
using System.Collections.Generic;

namespace IndieGameDevelopmentHubApp.Models;

public partial class Tester
{
    public decimal TesterId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime RegisterDate { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool? IsLicensed { get; set; }

    public virtual ICollection<BugReport> BugReports { get; set; } = new List<BugReport>();

    public virtual ICollection<TestersAccess> TestersAccesses { get; set; } = new List<TestersAccess>();
}
