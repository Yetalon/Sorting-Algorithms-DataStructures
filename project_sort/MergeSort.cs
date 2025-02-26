using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_sort
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MergeSort<T> : ISort<T> where T : IComparable<T>
    {
        
        /// <summary>
        /// Sorts the list
        /// </summary>
        /// <param name="values">The values in the list</param>
        public void Sort(List<T> values)
        {
            //base case is not needed no data used is less than or equal to 1
            if(values.Count <= 1)
            {
                return;
            }

            List<T> values1 = new List<T>();
            List<T> values2 = new List<T>();

        }
    }
}
