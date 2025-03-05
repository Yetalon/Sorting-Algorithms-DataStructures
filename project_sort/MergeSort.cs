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
            if (values.Count <= 1)
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
            int i = 0, leftIndex = 0, rightIndex = 0;
            int leftSize = valuesLeft.Count, rightSize = valuesRight.Count;

            while (leftIndex < leftSize && rightIndex < rightSize)
            {
                if (Comparer<T>.Default.Compare(valuesLeft[leftIndex], valuesRight[rightIndex]) <= 0)
                {
                    values[i] = valuesLeft[leftIndex];
                    leftIndex++;
                }
                else
                {
                    values[i] = valuesRight[rightIndex];
                    rightIndex++;
                }
                i++;
            }

            // Copy remaining elements from left list
            while (leftIndex < leftSize)
            {
                values[i] = valuesLeft[leftIndex];
                leftIndex++;
                i++;
            }

            // Copy remaining elements from right list
            while (rightIndex < rightSize)
            {
                values[i] = valuesRight[rightIndex];
                rightIndex++;
                i++;
            }
        }

    }
}
