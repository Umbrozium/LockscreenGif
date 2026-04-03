using System;
using System.IO;

namespace LockscreenGif.Services;

public static class TempDirectoryService
{
    public static string GetAppTempRoot()
    {
        var root = Path.Combine(
            AppContext.BaseDirectory,
            "Temp");

        Directory.CreateDirectory(root);
        return root;
    }
}
