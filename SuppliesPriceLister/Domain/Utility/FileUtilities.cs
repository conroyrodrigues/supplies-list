using System;
using System.IO;

namespace buildxact_supplies.Domain.Utility
{
    public static class FileUtilities
    {
        //TODO: Chnage this for a better approach
        public static string BasePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"));
    }
}
