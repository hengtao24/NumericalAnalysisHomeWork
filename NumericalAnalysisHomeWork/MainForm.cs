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
        Second Second = new Second();

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
            text = "计算结果是：" + "x* = " + Second.Newton(Convert.ToDouble(InitialValueTextBox.Text), Convert.ToDouble(ToleranceErrortextBox.Text));
            richTextBox2.Text = text;
        }

        private void PrintFindMaxSigmaResult()
        {
            string text = "";
            text = "最大Sigma是：" + "sigma = " + Second.FindMaxSigma(Convert.ToDouble(StepLengthtextBox.Text), Convert.ToDouble(ToleranceErrortextBox2.Text));
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
