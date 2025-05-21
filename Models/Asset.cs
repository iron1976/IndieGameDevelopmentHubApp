using System;
using System.Collections.Generic;

namespace IndieGameDevelopmentHubApp.Models;

public partial class Asset
{
    public decimal AssetId { get; set; }

    public decimal? GameId { get; set; }

    public string? AssetName { get; set; }

    public string? AssetType { get; set; }

    public decimal? DevId { get; set; }

    public DateTime? UploadDate { get; set; }

    public virtual Developer? Dev { get; set; }

    public virtual Game? Game { get; set; }
}
