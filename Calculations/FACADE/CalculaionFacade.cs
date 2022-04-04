using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Calculations.BusinessLogic;
using Calculations.Common;
using Calculations.Common.Interfaces;

namespace Calculations.FACADE
{
    /// <summary>
    /// CalculaionFacade respnsible to simplify the system and have acess point to different
    /// modules/class within he project
    /// </summary>
    public class CalculaionFacade
    {
        private readonly IFileService _fileService;

        readonly FileInfo _fileInformation = new FileInfo(Constants.FilePath);
        private readonly IntAddition _intAddition;
        private FileDataProcess _fileDataProcess;
        public CalculaionFacade()
        {
            _fileService = new FileService(_fileInformation);
            _intAddition = new IntAddition();
            _fileDataProcess = new FileDataProcess();
        }

        private string ReadFile()
        {
            return _fileService.ReadFile();
        }

        public string ReadFileDataProcess()
        {
            _fileDataProcess.FileData = ReadFile();
            _fileDataProcess.ProcessData();
            return _fileDataProcess.FileData;
        }

        private void WriteFile(string filepath, string result)
        {
            _fileService.WriteFile(filepath, result);
        }

        public void DoAddition()
        {
            var intAddition = new IntAddition() { LstData = _fileDataProcess.OnlyNumbers };
            intAddition.DoAddition();
            if (_fileDataProcess.NoNumbers.Count > 0)
            {
                Console.WriteLine("Following elements are not numeric values");
                foreach (string strLetter in _fileDataProcess.NoNumbers)
                {
                    Console.WriteLine(strLetter);
                }
            }

            WriteFile(Constants.ResultFilePath, "Reuslt Of Addition is " + Convert.ToString(intAddition.Result));
        }
    }
}
