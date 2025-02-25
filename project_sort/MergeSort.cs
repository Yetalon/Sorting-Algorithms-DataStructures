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
        /// 
        /// </summary>
        /// <param name="values"></param>
        public void Sort(List<T> values)
        {
            if(values.Count <= 1)
            {
                return;
            }
            List<T> values1 = new List<T>();
            List<T> values2 = new List<T>();

        }
    }
}
