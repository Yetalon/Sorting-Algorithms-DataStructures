using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_sort
{
    /// <summary>
    /// A generic implementation of InsertionSort.
    /// </summary>
    /// <typeparam name="T">Type of the list.</typeparam>
    internal class InsertionSort<T> : ISort<T> where T: IComparable<T>
    {
        /// <summary>
        /// Function to sort list using insertion sort.
        /// Compares item to every item after it until it is at the begining 
        /// or greater than the item after it. Repeats until list is sorted. 
        /// </summary>
        /// <param name="values">Items to sort.</param>
        public void Sort(List<T> values)
        {
            for(int i = 1; i < values.Count; i++) {
                T selectedItem = values[i];
                int positionToCompare = i - 1;
                //https://learn.microsoft.com/en-us/dotnet/api/system.string.compareto?view=net-9.0
                while (positionToCompare >= 0 && values[positionToCompare].CompareTo(selectedItem) > 0) {
                    values[positionToCompare + 1] = values[positionToCompare];
                    positionToCompare--;
                }
                values[positionToCompare + 1] = selectedItem;
            }
        }
    }
}
