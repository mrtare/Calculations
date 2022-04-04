using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Calculations.BusinessLogic;
using Calculations.Common;
using Calculations.Common.Interfaces;
using Calculations.FACADE;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {

            CalculaionFacade calc = new CalculaionFacade();
            try
            {
                if (calc.ReadFileDataProcess() != String.Empty)
                {
                    calc.DoAddition();
                    Console.WriteLine("Result of Addition is saved in file = " + Constants.ResultFilePath);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                //Here we can use Loggging Mechanism
            }
            Console.ReadLine();
            return;
            ////List<string> lstString = new List<string>() {"A",2,3,"4"};

            //string lines = File.ReadAllText(@"C:\Data\ReadFile.txt");

            ////var rlttr = Regex.Matches(lines, "(-?[A-Za-z]+)").OfType<Match>().Select(m => char.Parse(m.Value)).ToList();


            ////myInts = Regex.Matches(lines, "(-?[0-9]+)").OfType<Match>().Select(m => int.Parse(m.Value)).ToList();

            //var fileInformation = new FileInfo(Constants.FilePath);
            //IFileService fileOperations = new FileService(fileInformation);

            //var fileresult = fileOperations.IsFileExistsWithPermission();

            //var listStrLineElements = lines.Split(Constants.Delimeter).ToList();
            //int number = 0;
            //var onlyNumbers = (listStrLineElements.Where(x => int.TryParse(x, out number)).ToList()).ConvertAll(int.Parse);
            //var noNUmbers = listStrLineElements.Where(x => !int.TryParse(x, out number)).ToList();

            //var o = new IntAddition { LstData = onlyNumbers };
            //o.DoAddition();
            //Console.Write("Result is " + o.Result);
            //Console.ReadLine();

            //var o1 = new AlgorithmIntAddition { LstData = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } };
            //o1.DoAddition();
            //Console.Write("Result is " + o1.Result);
            //Console.ReadLine();

            //File.WriteAllText(@"C:\Data\AdditionResult.txt", Convert.ToString(o.Result));

        }
    }
}
