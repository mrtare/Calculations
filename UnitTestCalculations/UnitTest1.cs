using System;
using System.IO;
using Calculations;
using Calculations.Common;
using Calculations.FACADE;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCalculations
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestReadFileDoAddition()
    {
      var calc = new CalculaionFacade();
      calc.ReadFileDataProcess();
      calc.DoAddition();
    }
  }
}
