using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
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
            int mid = (values.Count) / 2;
            List<T> valuesLeft = values.GetRange(0, mid);
            List<T> valuesRight = values.GetRange(mid, values.Count - mid);
            Sort(valuesLeft);
            Sort(valuesRight);
            Merge(values, valuesLeft, valuesRight);
        }

        /// <summary>
        /// Merges the values together
        /// </summary>
        /// <param name="values">The original list</param>
        /// <param name="valuesLeft">The left list</param>
        /// <param name="valuesRight">The right list</param>
        private void Merge(List<T> values, List<T> valuesLeft, List<T> valuesRight)
        {
            int i = 0;
            while(valuesLeft.Count > 0 && valuesRight.Count > 0)
            {
                if(Comparer<T>.Default.Compare(valuesLeft, valuesRight))
                {

                }
            }
        }

    }
}
