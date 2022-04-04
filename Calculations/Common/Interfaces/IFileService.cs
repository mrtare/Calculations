using System.IO;

namespace Calculations.Common.Interfaces
{
    /// <summary>
    /// IFileService responsible to deal with file operations
    /// </summary>
    interface IFileService
    {
        bool IsFileExistsWithPermission();
        string ReadFile();
        bool WriteFile(string filePath, string data);
        FileInfo FileInformation { get; set; }
    }
}

