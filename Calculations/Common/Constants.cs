using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Common
{
    /// <summary>
    /// Responsible to define constants / codes used in project
    /// </summary>
    public static class Constants
    {
        public static string FilePath = Directory.GetCurrentDirectory() + @"\ReadFile.txt"; //@"C:\Data\ReadFile.txt";
        public static char Delimeter = ',';
        public static string ResultFilePath = Directory.GetCurrentDirectory() + @"\AdditionResult.txt"; //@"C:\Data\AdditionResult.txt";

        public static string ErrorCodeReadFile = "File Does not exist/Permission Issue";
    }
}
