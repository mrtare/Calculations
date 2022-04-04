using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculations.Common;
using Calculations.Common.Interfaces;

namespace Calculations.BusinessLogic
{
    /// <summary>
    /// IntAddition class responsible only for Actual Calculations/Addition purpose
    /// Implements IIntAddition interface
    /// Inherits the GenericBaseList class.
    /// </summary>
    class IntAddition : GenericBaseList<int>, IIntAddition
  {
    public virtual int DoAddition()
    {
      foreach (var currNum in LstData)
      {
        Result = Result + currNum;
      }
      return Result;
    }
  }
}
