using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Common
{
    /// <summary>
    /// GenericBaseList clas is responsible for holding the List of Data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    abstract class GenericBaseList<T>
    {
        private List<T> _lstData = new List<T>();

        public List<T> LstData
        {
            get { return _lstData; }
            set { _lstData = value; }
        }

        public T Result { get; set; }
    }
}
