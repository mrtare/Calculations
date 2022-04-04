using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.BusinessLogic
{
    /// <summary>
    /// AlgorithmIntAddition class is responsible for specific algorithm implementation & not Actual Addition
    /// Eg. here targetting only even numbers for addition
    /// Actually it reuses the Base Class Logic to do addition 
    /// Open Close principle
    /// </summary>
    class AlgorithmIntAddition : IntAddition
  {
    public override int DoAddition()
    {
      LstData = LstData.Where(i => i % 2 == 0).ToList();
      return base.DoAddition();
    }
  }
}
