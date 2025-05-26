using System;
using System.Collections.Generic;

namespace IndieGameDevelopmentHubApp.Models;

public partial class AssetOwnerDetail
{
    public decimal AssetId { get; set; }

    public string? AssetName { get; set; }

    public string? AssetType { get; set; }

    public DateTime? UploadDate { get; set; }

    public string DeveloperName { get; set; } = null!;

    public string GameTitle { get; set; } = null!;
}
