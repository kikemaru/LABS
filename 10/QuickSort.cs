using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viborSortQuickSort
{
    public class QuickSort : IStrategy
    {
        public int iterationCount = 0;
        public static Form1 form1;
        public void SortAnalysis(int[] array, int a, int b)
        {
            int i = a;
            int j = b;
            int middle = array[(a + b) / 2];
            while (i <= j)
            {
                while (array[i] < middle)
                {
                    i++;
                }
                while (array[j] > middle)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temporaryVariable = array[i];
                    array[i] = array[j];
                    array[j] = temporaryVariable;
                    i++;
                    j--;
                }
                ComparativeAnalysis.NumberOfPermutations++;
            }
            ComparativeAnalysis.Comparison++;
            if (a < j)
            {
                SortAnalysis(array, a, j);
            }
            if (i < b)
            {
                SortAnalysis(array, i, b);
            }
        }
        public void SortAnalysisFlag(int[] array, int a, int b)
        {
            int i = a;
            int j = b;
            int middle = array[(a + b) / 2];
            while (i <= j)
            {
                while (array[i] < middle)
                {
                    i++;
                }
                while (array[j] > middle)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temporaryVariable = array[i];
                    array[i] = array[j];
                    array[j] = temporaryVariable;
                    i++;
                    j--;
                }
                IOFile.content += this.iterationCount.ToString() + " итерация: " + '\n';
                IOFile.InputInfoAboutComparison(array[i], array[j]);
                IOFile.InputInfoAboutTransposition(array[i], array[j]);
                IOFile.FillContent();
                ComparativeAnalysis.NumberOfPermutations++;
            }
            this.iterationCount++;
            ComparativeAnalysis.Comparison++;
            form1.AddItemsListBox(array[i]);
            if (a < j)
            {
                SortAnalysisFlag(array, a, j);
            }
            if (i < b)
            {
                SortAnalysisFlag(array, i, b);
            }
        }
        public int[] Algorithm(int[] mas, bool flag = true)
        {
            if (flag)
            {
                IOFile.FillContent();
                System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
                myStopwatch.Start();
                SortAnalysisFlag(mas, 0, mas.Length - 1);
                myStopwatch.Stop();
                var resultTime = myStopwatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                    resultTime.Hours,
                    resultTime.Minutes,
                    resultTime.Seconds,
                    resultTime.Milliseconds);
                form1.labelCountComparison.Text = Convert.ToString(ComparativeAnalysis.Comparison);
                form1.labelNumberOfPermutations.Text = Convert.ToString(ComparativeAnalysis.NumberOfPermutations);
                form1.labelTimeSort.Text = elapsedTime;
                return mas;
            }
            else
            {
                System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
                myStopwatch.Start();
                SortAnalysis(mas, 0, mas.Length - 1);
                myStopwatch.Stop();
                var resultTime = myStopwatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                    resultTime.Hours,
                    resultTime.Minutes,
                    resultTime.Seconds,
                    resultTime.Milliseconds);
                ComparativeAnalysis.timeSort = resultTime.Seconds * 1000 + resultTime.Milliseconds;
                ComparativeAnalysis.elapsedTime = elapsedTime;
                return mas;
            }
        }
    }
}
