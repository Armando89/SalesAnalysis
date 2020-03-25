using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SalesAnalysis
{
    public partial class SalesAnalysisForm : Form
    {
        public SalesAnalysisForm()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            TotalLabel.Text = "";
            AverageLabel.Text = "";
            HighestLabel.Text = "";
            LowestLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double Total(double[] salesArray)
        {
            int index;
            double sum = 0.0;

            for (index = 0; index < salesArray.Length; index++)
            {
                sum += salesArray[index];
            }

            return sum;
        }

        private double Average(double[] salesArray)
        {
            int index;
            double avrg = 0.0;
            double average;

            for (index = 0; index < salesArray.Length; index++)
            {
                avrg += salesArray[index];
            }

            average = avrg / salesArray.Length;

            return average;
        }

        private double Highest(double[] salesArray)
        {
            int index;
            double highest = salesArray[0];

            for (index = 1; index < salesArray.Length; index++)
            {
                if (salesArray[index] > highest)
                {
                    highest = salesArray[index];
                }
            }

            return highest;
        }

        private double Lowest(double[] salesArray)
        {
            int index;
            double lowest = salesArray[0];

            for (index = 1; index < salesArray.Length; index++)
            {
                if (salesArray[index] < lowest)
                {
                    lowest = salesArray[index];
                }
            }

            return lowest;
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            try
            {
                const int SIZE = 7;
                double[] num = new double[SIZE];

                int index = 0;

                StreamReader inputFile;

                inputFile = File.OpenText("Sales.txt");

                while (index < num.Length && !inputFile.EndOfStream)
                {
                    num[index] = double.Parse(inputFile.ReadLine());
                    index++;
                }

                inputFile.Close();

                foreach (double value in num)
                {
                    ValuesListBox.Items.Add(value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                const int ARR_SIZE = 7;
                double[] results = new double[ARR_SIZE];
                int index = 0;
                double totalSum, aver, high, low;
                StreamReader input;

                input = File.OpenText("Sales.txt");

                while (!input.EndOfStream && index < results.Length)
                {
                    results[index] = double.Parse(input.ReadLine());
                    index++;
                }

                input.Close();

                foreach (double numbers in results)
                {
                    ValuesListBox.Items.Add(numbers);
                }

                totalSum = Total(results);
                aver = Average(results);
                high = Highest(results);
                low = Lowest(results);

                TotalLabel.Text = totalSum.ToString();
                AverageLabel.Text = aver.ToString("n2");
                HighestLabel.Text = high.ToString();
                LowestLabel.Text = low.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
