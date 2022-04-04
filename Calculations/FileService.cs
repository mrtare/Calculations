using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Calculations.Common;
using Calculations.Common.Interfaces;

namespace Calculations
{
    /// <summary>
    /// FileService implments the IFileService 
    /// And is reponsible for actual file read/write/access permission
    /// </summary>
    public class FileService : IFileService
    {
        private FileInfo _fileInformation;

        public FileInfo FileInformation
        {
            get { return _fileInformation; }
            set { _fileInformation = value; }
        }


        public FileService(FileInfo fileinfo)
        {
            FileInformation = fileinfo;
        }

        public bool IsFileExistsWithPermission()
        {
            try
            {
                using (FileStream stream = FileInformation.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return false;
            }

            //file is not locked/available
            return true;
        }

        public string ReadFile()
        {
            string fileData;
            fileData = IsFileExistsWithPermission() ? File.ReadAllText(FileInformation.FullName) : throw new IOException(Constants.ErrorCodeReadFile +"\n"+ FileInformation.FullName);
            return fileData;
        }

        public bool WriteFile(string filePath, string data)
        {
            File.WriteAllText(filePath, Convert.ToString(data));
            return true;
        }

    }
}
