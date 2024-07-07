using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateCashDiscount
{
    public partial class MainForm : Form
    {
        // 起始现金;
        private float haveCash = 0;

        // 股本;
        private float capitalStock = 0;

        // 折现率;
        private float discountRate = 0.0f;

        // 自由现金流;
        private List<float> totalCashList = new List<float>();

        // 现金流折现值;
        private List<float> discountCashList = new List<float>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxCash.Text)){
                MessageBox.Show("自由现金流不能为空!");
                return;
            }

            // 股本;
            if (!string.IsNullOrEmpty(this.textBoxCapitalStock.Text))
                this.capitalStock = float.Parse(this.textBoxCapitalStock.Text);
            else
                this.capitalStock = 0.0f;

            // 起始现金;
            this.haveCash = float.Parse(this.textBoxCash.Text);

            // 获得折现率;
            this.discountRate = this.GetRate(this.comboBoxDiscountRate.Text);

            // 开始计算;
            this.Calculate();
        }

        private void textBoxCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && e.KeyChar != '.' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCapitalStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && e.KeyChar != '.' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Calculate()
        {
            if (!this.CalculateStage1())
                return;

            if (!this.CalculateStage2())
                return;

            this.CalculateResult();
        }

        private bool CalculateStage1()
        {
            int startYear = int.Parse(this.comboBoxStartYear1.Text);
            int endYear = int.Parse(this.comboBoxEndYear1.Text);

            if(startYear >= endYear)
            {
                MessageBox.Show("截止年份必须大于开始年份!");
                return false;
            }

            // 净利润增长率;
            float growRate = this.GetRate(this.comboBoxGrowthRate1.Text);

            this.totalCashList.Clear();
            this.discountCashList.Clear();

            float freeCash = 0;
            float discountCash = 0;

            int count = endYear - startYear + 1;
            for (int i = 0; i < count; i++)
            {
                if(totalCashList.Count <= 0)
                {
                    freeCash = this.haveCash * (1.0f + growRate);
                    discountCash = (float)(freeCash / Math.Pow(1.0f + this.discountRate, i + 1));

                    this.totalCashList.Add(freeCash);
                    this.discountCashList.Add(discountCash);
                }
                else
                {
                    freeCash = totalCashList[i - 1] * (1.0f + growRate);
                    discountCash = (float)(freeCash / Math.Pow(1.0f + this.discountRate, i + 1));

                    totalCashList.Add(freeCash);
                    this.discountCashList.Add(discountCash);
                }
            }

            return true;
        }

        private bool CalculateStage2()
        {
            int startYear = int.Parse(this.comboBoxStartYear1.Text);
            int endYear = int.Parse(this.comboBoxStartYear2.Text);

            // 净利润增长率;
            float growRate = this.GetRate(this.comboBoxGrowthRate2.Text);

            int count = endYear - startYear + 1;

            float freeCash = totalCashList[totalCashList.Count - 1] * (1.0f + growRate) * (1.0f + this.discountRate) / (this.discountRate - growRate);
            float discountCash = (float)(freeCash / Math.Pow(1.0f + this.discountRate, count));

            this.totalCashList.Add(freeCash);
            this.discountCashList.Add(discountCash);

            return true;
        }

        private void CalculateResult()
        {
            float totalDiscountCash = 0.0f;

            for (int i = 0; i < this.discountCashList.Count; i++)
                totalDiscountCash += this.discountCashList[i];

            // 估值;
            this.textBoxValuation.Text = totalDiscountCash.ToString();

            // 股价;
            if (this.capitalStock > 0)
                this.textBoxStockPrice.Text = (totalDiscountCash / this.capitalStock).ToString();
        }

        private float GetRate(string value)
        {
            float rate = 0.0f;

            if(!string.IsNullOrEmpty(value))
            {
                value.Trim();

                string strRate = value.Replace("%", "");
                float.TryParse(strRate, out rate);

                rate /= 100.0f;
            }

            return rate;
        }
    }
}
