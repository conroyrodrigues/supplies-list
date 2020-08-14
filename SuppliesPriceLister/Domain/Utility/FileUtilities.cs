using System;
using System.IO;

namespace buildxact_supplies.Domain.Utility
{
    public static class FileUtilities
    {
        // TODO: A better way to do this, might not work with Linux File Systems
        public static string BasePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"));
    }
}
