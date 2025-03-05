using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_sort
{
    /// <summary>
    /// The interface the algorithms will use
    /// </summary>
    public interface ISort<T>
    {
        /// <summary>
        /// Each algortihm will have to have a sort being generic
        /// </summary>
        /// <param name="values">The values need to be sorted</param>
        void Sort(List<T> values);
    }
}
