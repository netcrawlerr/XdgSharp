namespace XdgSharp.Portals.Models;

public sealed record ScreenshotOptions
{
    public bool Interactive { get; init; } = false;

    public bool Modal { get; init; } = false;

    public string ParentWindow { get; set; } = string.Empty;
}
