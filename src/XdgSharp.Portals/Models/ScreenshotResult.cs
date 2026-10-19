namespace XdgSharp.Portals.Models;

public sealed record ScreenshotResult(
    bool Success,
    string? LocalPath = null,
    string? RawUri = null,
    uint ResponseCode = 0,
    string? ErrorMessage = null
);
