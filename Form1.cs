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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            double[] numbers = {  };
 


        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
        }
    }
}
