using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumericalAnalysisHomeWork
{
    public partial class MainForm : Form
    {   
        // 
        First first = new First();
        Second second = new Second();
        Third third = new Third();
        Fourth fourth = new Fourth();
        Fifth fifth = new Fifth();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PrintFirstResult();
            StartIterationbutton.Enabled = false;
            FindMaxSigmabutton.Enabled = false;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPage1)
            {
                PrintFirstResult();
            }
            if (e.TabPage == tabPage2)
            {
                ToleranceErrortextBox.Text = "" + 0.000001;
                ToleranceErrortextBox2.Text = "" + 0.000001;
            }
            if (e.TabPage == tabPage3)
            {
                PrintThirdResult();
            }
            if (e.TabPage == tabPage4)
            {
                PrintFourthResult();
            }
            if (e.TabPage == tabPage5)
            {
                PrintFifthResult();
            }
        }

        private void PrintFirstResult()
        {
            string text = "";
            float result1 = first.RealResult(100);
            float result2 = first.RealResult(10000);
            float result3 = first.RealResult(1000000);
            text = "精确值：\n" + "S1=" + result1 + " S2=" + result2 + " S3=" + result3 ;

            float result4 = first.SUMFromBigToSmall(100);
            float result5 = first.SUMFromBigToSmall(10000);
            float result6 = first.SUMFromBigToSmall(1000000);
            text += "\n从大到小计算结果为：\n" + "S1=" + result4 + " 误差为：" + (float)Math.Abs(result1 - result4);
            text += "\nS2=" + result5 + " 误差为：" + (float)Math.Abs(result2 - result5);
            text += "\nS3=" + result6 + " 误差为：" + (float)Math.Abs(result3 - result6);

            float result7 = first.SUMFromSmallToBig(100);
            float result8 = first.SUMFromSmallToBig(10000);
            float result9 = first.SUMFromSmallToBig(1000000);
            text += "\n从小到大计算结果为：\n" + "S1=" + result7 + " 误差为：" + (float)Math.Abs(result1 - result7);
            text += "\nS2=" + result8 + " 误差为：" + (float)Math.Abs(result2 - result8);
            text += "\nS3=" + result9 + " 误差为：" + (float)Math.Abs(result3 - result9);
            richTextBox1.Text = text;
            richTextBox1.Enabled = false;
        }

        private void PrintNewtonResult()
        {
            string text = "";
            text = "计算结果是：" + "x* = " + second.Newton(Convert.ToDouble(InitialValueTextBox.Text), Convert.ToDouble(ToleranceErrortextBox.Text));
            richTextBox2.Text = text;
        }

        private void PrintThirdResult()
        {
            double[,] arrray1 = new double[9, 9] { { 31, -13, 0, 0, 0, -10, 0, 0, 0 }, { -13, 35, -9, 0, -11, 0, 0, 0, 0 },{0, -9, 31, -10, 0, 0, 0, 0, 0},{0 ,0 ,-10, 79, -30, 0, 0, 0, -9},{0, 0, 0 ,-30, 57 ,-7 ,0, -5, 0},
            {0 ,0 ,0, 0 ,-7, 47, -30 ,0, 0},{0, 0, 0 ,0 ,0, -30 ,41, 0 ,0},{0 ,0 ,0, 0, -5, 0, 0, 27, -2},{0 ,0 ,0 ,-9 ,0 ,0 ,0 ,-2, 29}};
            double[] result = third.ColumnPrincipalGauss(arrray1, new double[] { -15, 27, -23, 0, -20, 12, -7, 7, 10 });
            string text = "";
            text = "方程组的解是：\n" + result[0] + "\n" + result[1] + "\n" + result[2] + "\n" + result[3] + "\n" + result[4] + "\n"
                + result[5] + "\n" + result[6] + "\n" + result[7] + "\n" + result[8];
            richTextBox3.Text = text;
        }

        private void PrintFourthResult()
        {
            richTextBox4.Text = "";
            double[] x = new double[] {0,1,2,3,4,5,6,7,8,9,10 };
            double[] y = new double[] { 2.51,3.30,4.04,4.70,5.22,5.54,5.78,5.40,5.57,5.70,5.80};
            double y_0 = 0.8;
            double y_n = 0.2;
            double[] M = fourth.CalculateSx(x, y, y_0, y_n);
            double r;
            int len = x.Length;
            richTextBox4.Text += "S(x)的结果如下:";
            richTextBox4.Text += "\r";
		    for(int i=0;i<len-1;i++)
		    {
		    	r=(y[i+1]-y[i])/(x[i+1]-x[i])-(M[i]*(1.0/3)+M[i+1]*(1.0/6))*(x[i+1]-x[i]);
		    	string text = "在区间（"+x[i]+","+x[i+1]+"内)：S(x)="+y[i]+"+("+r+")*(x-"+x[i]+")+("+0.5*M[i]+")*(x-"+x[i]+")^2+("+1/(6*(x[i+1]-x[i]))*(M[i+1]-M[i])+")*(x-"+x[i]+")^3";
                richTextBox4.Text += text;
                richTextBox4.Text += "\r";
		    }
            richTextBox4.Text += "S(i+0.5)的结果如下:";
            richTextBox4.Text += "\r";
		    double []S=new double [len];
		    for(int i=0;i<len-1;i++)
		    {
		    	r=(y[i+1]-y[i])/(x[i+1]-x[i])-(M[i]/3+M[i+1]/6)*(x[i+1]-x[i]);
		    	S[i]=y[i]+r*0.5+0.5*M[i]*(0.5)*(0.5)+1/(6*(x[i+1]-x[i]))*(M[i+1]-M[i])*0.5*0.5*0.5;
                string text = "S["+(i+0.5)+"]="+S[i];
                richTextBox4.Text += text;
                richTextBox4.Text += "\r";
		    }

        }

        private void PrintFifthResult() 
        {
            richTextBox5.Text = "";
            double a = 0;
            double b = Math.PI / 3;
            double c = 0;
            double d = Math.PI / 6;

            double ToleranceError = 5E-6;

            richTextBox5.Text = fifth.CalculateResult(a, b, c, d, ToleranceError);

        }

        private void PrintFindMaxSigmaResult()
        {
            string text = "";
            text = "最大Sigma是：" + "sigma = " + second.FindMaxSigma(Convert.ToDouble(StepLengthtextBox.Text), Convert.ToDouble(ToleranceErrortextBox2.Text));
            richTextBox2.Text = text;
        }

        private void StartIterationbutton_Click(object sender, EventArgs e)
        {
            PrintNewtonResult();
        }

        private void FindMaxSigmabutton_Click(object sender, EventArgs e)
        {
            PrintFindMaxSigmaResult();
        }

        private void InitialValueTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(InitialValueTextBox.Text) && !String.IsNullOrEmpty(ToleranceErrortextBox.Text))
            {
                StartIterationbutton.Enabled = true;
            }
        }

        private void ToleranceErrortextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(InitialValueTextBox.Text) && !String.IsNullOrEmpty(ToleranceErrortextBox.Text))
            {
                StartIterationbutton.Enabled = true;
            }
        }

        private void StepLengthtextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(StepLengthtextBox.Text) && !String.IsNullOrEmpty(ToleranceErrortextBox2.Text))
            {
                FindMaxSigmabutton.Enabled = true;
            }
        }

        private void ToleranceErrortextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(StepLengthtextBox.Text) && !String.IsNullOrEmpty(ToleranceErrortextBox2.Text))
            {
                FindMaxSigmabutton.Enabled = true;
            }
        }
       
    }
}
