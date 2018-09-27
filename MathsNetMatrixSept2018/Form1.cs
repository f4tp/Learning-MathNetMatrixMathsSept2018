using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.Data.Text;

namespace MathsNetMatrixSept2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //takes a matrix in a text file (1,1),(3,4) and the same underneath.. and reads them in
            //args for method = file path, booleal true if sparse matrix, string delimiter, boolean true if it has headers
            Matrix<Complex32> fileMatrix = DelimitedReader.Read<Complex32>(@"D:\My Documents\Paul Docs\Education, training, employment\Job\1 Research\C#\2 Tutorials Vids\3 Odds n Sods\3 Math.Net Vector math\csv.txt", false, ",", false);
            textBox1.AppendText(fileMatrix.ToString("F2"));
        }
    }
}
