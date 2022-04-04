using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculations.Common;

namespace Calculations.BusinessLogic
{
    /// <summary>
    /// FileDataProcess class responsible only for data processing 
    /// Typically data which we receive after reading files
    /// </summary>
    class FileDataProcess
    {
        List<int> _onlyNumbers;
        List<string> _noNumbers;
        private string _fileData;

        public FileDataProcess()
        {
            _onlyNumbers = new List<int>();
            _noNumbers = new List<string>();
        }
        public string FileData
        {
            get { return _fileData; }
            set { _fileData = value; }
        }

        public List<int> OnlyNumbers
        {
            get { return _onlyNumbers; }
            set { _onlyNumbers = value; }
        }

        public List<string> NoNumbers
        {
            get { return _noNumbers; }
            set { _noNumbers = value; }
        }

        public void ProcessData()
        {
            var listStrLineElements = FileData.Split(Constants.Delimeter).ToList();
            int number = 0;
            _onlyNumbers = (listStrLineElements.Where(x => int.TryParse(x, out number)).ToList()).ConvertAll(int.Parse);
            _noNumbers = listStrLineElements.Where(x => !int.TryParse(x, out number)).ToList();
        }
    }
}
