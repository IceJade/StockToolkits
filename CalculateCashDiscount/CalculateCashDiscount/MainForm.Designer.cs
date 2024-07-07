namespace CalculateCashDiscount
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelStartYear1 = new System.Windows.Forms.Label();
            this.comboBoxStartYear1 = new System.Windows.Forms.ComboBox();
            this.labelEndYear1 = new System.Windows.Forms.Label();
            this.groupBoxStage1 = new System.Windows.Forms.GroupBox();
            this.comboBoxGrowthRate1 = new System.Windows.Forms.ComboBox();
            this.labelNetProfitGrowthRate1 = new System.Windows.Forms.Label();
            this.comboBoxEndYear1 = new System.Windows.Forms.ComboBox();
            this.comboBoxDiscountRate = new System.Windows.Forms.ComboBox();
            this.labelDiscountRate = new System.Windows.Forms.Label();
            this.groupBoxBaseData = new System.Windows.Forms.GroupBox();
            this.textBoxCapitalStock = new System.Windows.Forms.TextBox();
            this.labelCapitalStock = new System.Windows.Forms.Label();
            this.textBoxCash = new System.Windows.Forms.TextBox();
            this.labelCash = new System.Windows.Forms.Label();
            this.groupBoxStage2 = new System.Windows.Forms.GroupBox();
            this.comboBoxGrowthRate2 = new System.Windows.Forms.ComboBox();
            this.labelNetProfitGrowthRate2 = new System.Windows.Forms.Label();
            this.comboBoxEndYear2 = new System.Windows.Forms.ComboBox();
            this.labelEndYear2 = new System.Windows.Forms.Label();
            this.comboBoxStartYear2 = new System.Windows.Forms.ComboBox();
            this.labelStartYear2 = new System.Windows.Forms.Label();
            this.labelValuation = new System.Windows.Forms.Label();
            this.textBoxValuation = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelStockPrice = new System.Windows.Forms.Label();
            this.textBoxStockPrice = new System.Windows.Forms.TextBox();
            this.groupBoxStage1.SuspendLayout();
            this.groupBoxBaseData.SuspendLayout();
            this.groupBoxStage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStartYear1
            // 
            this.labelStartYear1.AutoSize = true;
            this.labelStartYear1.Location = new System.Drawing.Point(19, 30);
            this.labelStartYear1.Name = "labelStartYear1";
            this.labelStartYear1.Size = new System.Drawing.Size(65, 12);
            this.labelStartYear1.TabIndex = 0;
            this.labelStartYear1.Text = "起始年份：";
            // 
            // comboBoxStartYear1
            // 
            this.comboBoxStartYear1.FormattingEnabled = true;
            this.comboBoxStartYear1.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.comboBoxStartYear1.Location = new System.Drawing.Point(90, 27);
            this.comboBoxStartYear1.Name = "comboBoxStartYear1";
            this.comboBoxStartYear1.Size = new System.Drawing.Size(54, 20);
            this.comboBoxStartYear1.TabIndex = 2;
            this.comboBoxStartYear1.Text = "2019";
            // 
            // labelEndYear1
            // 
            this.labelEndYear1.AutoSize = true;
            this.labelEndYear1.Location = new System.Drawing.Point(201, 30);
            this.labelEndYear1.Name = "labelEndYear1";
            this.labelEndYear1.Size = new System.Drawing.Size(65, 12);
            this.labelEndYear1.TabIndex = 3;
            this.labelEndYear1.Text = "截止年份：";
            // 
            // groupBoxStage1
            // 
            this.groupBoxStage1.Controls.Add(this.comboBoxGrowthRate1);
            this.groupBoxStage1.Controls.Add(this.labelNetProfitGrowthRate1);
            this.groupBoxStage1.Controls.Add(this.comboBoxEndYear1);
            this.groupBoxStage1.Controls.Add(this.labelEndYear1);
            this.groupBoxStage1.Controls.Add(this.comboBoxStartYear1);
            this.groupBoxStage1.Controls.Add(this.labelStartYear1);
            this.groupBoxStage1.Location = new System.Drawing.Point(12, 91);
            this.groupBoxStage1.Name = "groupBoxStage1";
            this.groupBoxStage1.Size = new System.Drawing.Size(527, 65);
            this.groupBoxStage1.TabIndex = 4;
            this.groupBoxStage1.TabStop = false;
            this.groupBoxStage1.Text = "第一阶段";
            // 
            // comboBoxGrowthRate1
            // 
            this.comboBoxGrowthRate1.FormattingEnabled = true;
            this.comboBoxGrowthRate1.Items.AddRange(new object[] {
            "0%",
            "1%",
            "2%",
            "3%",
            "4%",
            "5%",
            "6%",
            "7%",
            "8%",
            "9%",
            "10%",
            "11%",
            "12%",
            "13%",
            "14%",
            "15%",
            "16%",
            "17%",
            "18%",
            "19%",
            "20%",
            "22%",
            "25%",
            "28%",
            "30%",
            "32%",
            "35%",
            "40%",
            "45%",
            "50%"});
            this.comboBoxGrowthRate1.Location = new System.Drawing.Point(453, 27);
            this.comboBoxGrowthRate1.Name = "comboBoxGrowthRate1";
            this.comboBoxGrowthRate1.Size = new System.Drawing.Size(50, 20);
            this.comboBoxGrowthRate1.TabIndex = 6;
            this.comboBoxGrowthRate1.Text = "15%";
            // 
            // labelNetProfitGrowthRate1
            // 
            this.labelNetProfitGrowthRate1.AutoSize = true;
            this.labelNetProfitGrowthRate1.Location = new System.Drawing.Point(366, 30);
            this.labelNetProfitGrowthRate1.Name = "labelNetProfitGrowthRate1";
            this.labelNetProfitGrowthRate1.Size = new System.Drawing.Size(89, 12);
            this.labelNetProfitGrowthRate1.TabIndex = 5;
            this.labelNetProfitGrowthRate1.Text = "净利润增长率：";
            // 
            // comboBoxEndYear1
            // 
            this.comboBoxEndYear1.FormattingEnabled = true;
            this.comboBoxEndYear1.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "永续"});
            this.comboBoxEndYear1.Location = new System.Drawing.Point(272, 27);
            this.comboBoxEndYear1.Name = "comboBoxEndYear1";
            this.comboBoxEndYear1.Size = new System.Drawing.Size(51, 20);
            this.comboBoxEndYear1.TabIndex = 4;
            this.comboBoxEndYear1.Text = "2028";
            // 
            // comboBoxDiscountRate
            // 
            this.comboBoxDiscountRate.FormattingEnabled = true;
            this.comboBoxDiscountRate.Items.AddRange(new object[] {
            "0%",
            "1%",
            "2%",
            "3%",
            "4%",
            "5%",
            "6%",
            "7%",
            "8%",
            "9%",
            "10%",
            "11%",
            "12%",
            "13%",
            "14%",
            "15%",
            "16%",
            "17%",
            "18%",
            "19%",
            "20%",
            "22%",
            "25%",
            "28%",
            "30%",
            "32%",
            "35%",
            "40%",
            "45%",
            "50%"});
            this.comboBoxDiscountRate.Location = new System.Drawing.Point(453, 31);
            this.comboBoxDiscountRate.Name = "comboBoxDiscountRate";
            this.comboBoxDiscountRate.Size = new System.Drawing.Size(50, 20);
            this.comboBoxDiscountRate.TabIndex = 8;
            this.comboBoxDiscountRate.Text = "10%";
            // 
            // labelDiscountRate
            // 
            this.labelDiscountRate.AutoSize = true;
            this.labelDiscountRate.Location = new System.Drawing.Point(405, 34);
            this.labelDiscountRate.Name = "labelDiscountRate";
            this.labelDiscountRate.Size = new System.Drawing.Size(53, 12);
            this.labelDiscountRate.TabIndex = 7;
            this.labelDiscountRate.Text = "折现率：";
            // 
            // groupBoxBaseData
            // 
            this.groupBoxBaseData.Controls.Add(this.textBoxCapitalStock);
            this.groupBoxBaseData.Controls.Add(this.labelCapitalStock);
            this.groupBoxBaseData.Controls.Add(this.comboBoxDiscountRate);
            this.groupBoxBaseData.Controls.Add(this.textBoxCash);
            this.groupBoxBaseData.Controls.Add(this.labelDiscountRate);
            this.groupBoxBaseData.Controls.Add(this.labelCash);
            this.groupBoxBaseData.Location = new System.Drawing.Point(12, 18);
            this.groupBoxBaseData.Name = "groupBoxBaseData";
            this.groupBoxBaseData.Size = new System.Drawing.Size(527, 67);
            this.groupBoxBaseData.TabIndex = 5;
            this.groupBoxBaseData.TabStop = false;
            this.groupBoxBaseData.Text = "基础数据";
            // 
            // textBoxCapitalStock
            // 
            this.textBoxCapitalStock.Location = new System.Drawing.Point(323, 31);
            this.textBoxCapitalStock.Name = "textBoxCapitalStock";
            this.textBoxCapitalStock.Size = new System.Drawing.Size(60, 21);
            this.textBoxCapitalStock.TabIndex = 10;
            this.textBoxCapitalStock.Text = "12.6";
            this.textBoxCapitalStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCapitalStock_KeyPress);
            // 
            // labelCapitalStock
            // 
            this.labelCapitalStock.AutoSize = true;
            this.labelCapitalStock.Location = new System.Drawing.Point(254, 34);
            this.labelCapitalStock.Name = "labelCapitalStock";
            this.labelCapitalStock.Size = new System.Drawing.Size(77, 12);
            this.labelCapitalStock.TabIndex = 9;
            this.labelCapitalStock.Text = "股本(亿股)：";
            // 
            // textBoxCash
            // 
            this.textBoxCash.Location = new System.Drawing.Point(152, 30);
            this.textBoxCash.Name = "textBoxCash";
            this.textBoxCash.Size = new System.Drawing.Size(72, 21);
            this.textBoxCash.TabIndex = 1;
            this.textBoxCash.Text = "340";
            this.textBoxCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCash_KeyPress);
            // 
            // labelCash
            // 
            this.labelCash.AutoSize = true;
            this.labelCash.Location = new System.Drawing.Point(19, 34);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(137, 12);
            this.labelCash.TabIndex = 0;
            this.labelCash.Text = "初始现金流(亿人民币)：";
            // 
            // groupBoxStage2
            // 
            this.groupBoxStage2.Controls.Add(this.comboBoxGrowthRate2);
            this.groupBoxStage2.Controls.Add(this.labelNetProfitGrowthRate2);
            this.groupBoxStage2.Controls.Add(this.comboBoxEndYear2);
            this.groupBoxStage2.Controls.Add(this.labelEndYear2);
            this.groupBoxStage2.Controls.Add(this.comboBoxStartYear2);
            this.groupBoxStage2.Controls.Add(this.labelStartYear2);
            this.groupBoxStage2.Location = new System.Drawing.Point(12, 162);
            this.groupBoxStage2.Name = "groupBoxStage2";
            this.groupBoxStage2.Size = new System.Drawing.Size(527, 65);
            this.groupBoxStage2.TabIndex = 7;
            this.groupBoxStage2.TabStop = false;
            this.groupBoxStage2.Text = "第二阶段";
            // 
            // comboBoxGrowthRate2
            // 
            this.comboBoxGrowthRate2.FormattingEnabled = true;
            this.comboBoxGrowthRate2.Items.AddRange(new object[] {
            "0%",
            "1%",
            "2%",
            "3%",
            "4%",
            "5%",
            "6%",
            "7%",
            "8%",
            "9%",
            "10%",
            "11%",
            "12%",
            "13%",
            "14%",
            "15%",
            "16%",
            "17%",
            "18%",
            "19%",
            "20%",
            "22%",
            "25%",
            "28%",
            "30%",
            "32%",
            "35%",
            "40%",
            "45%",
            "50%"});
            this.comboBoxGrowthRate2.Location = new System.Drawing.Point(453, 27);
            this.comboBoxGrowthRate2.Name = "comboBoxGrowthRate2";
            this.comboBoxGrowthRate2.Size = new System.Drawing.Size(50, 20);
            this.comboBoxGrowthRate2.TabIndex = 6;
            this.comboBoxGrowthRate2.Text = "5%";
            // 
            // labelNetProfitGrowthRate2
            // 
            this.labelNetProfitGrowthRate2.AutoSize = true;
            this.labelNetProfitGrowthRate2.Location = new System.Drawing.Point(366, 30);
            this.labelNetProfitGrowthRate2.Name = "labelNetProfitGrowthRate2";
            this.labelNetProfitGrowthRate2.Size = new System.Drawing.Size(89, 12);
            this.labelNetProfitGrowthRate2.TabIndex = 5;
            this.labelNetProfitGrowthRate2.Text = "净利润增长率：";
            // 
            // comboBoxEndYear2
            // 
            this.comboBoxEndYear2.FormattingEnabled = true;
            this.comboBoxEndYear2.Items.AddRange(new object[] {
            "永续"});
            this.comboBoxEndYear2.Location = new System.Drawing.Point(272, 27);
            this.comboBoxEndYear2.Name = "comboBoxEndYear2";
            this.comboBoxEndYear2.Size = new System.Drawing.Size(51, 20);
            this.comboBoxEndYear2.TabIndex = 4;
            this.comboBoxEndYear2.Text = "永续";
            // 
            // labelEndYear2
            // 
            this.labelEndYear2.AutoSize = true;
            this.labelEndYear2.Location = new System.Drawing.Point(201, 30);
            this.labelEndYear2.Name = "labelEndYear2";
            this.labelEndYear2.Size = new System.Drawing.Size(65, 12);
            this.labelEndYear2.TabIndex = 3;
            this.labelEndYear2.Text = "截止年份：";
            // 
            // comboBoxStartYear2
            // 
            this.comboBoxStartYear2.FormattingEnabled = true;
            this.comboBoxStartYear2.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.comboBoxStartYear2.Location = new System.Drawing.Point(90, 27);
            this.comboBoxStartYear2.Name = "comboBoxStartYear2";
            this.comboBoxStartYear2.Size = new System.Drawing.Size(54, 20);
            this.comboBoxStartYear2.TabIndex = 2;
            this.comboBoxStartYear2.Text = "2029";
            // 
            // labelStartYear2
            // 
            this.labelStartYear2.AutoSize = true;
            this.labelStartYear2.Location = new System.Drawing.Point(19, 30);
            this.labelStartYear2.Name = "labelStartYear2";
            this.labelStartYear2.Size = new System.Drawing.Size(65, 12);
            this.labelStartYear2.TabIndex = 0;
            this.labelStartYear2.Text = "起始年份：";
            // 
            // labelValuation
            // 
            this.labelValuation.AutoSize = true;
            this.labelValuation.Location = new System.Drawing.Point(18, 245);
            this.labelValuation.Name = "labelValuation";
            this.labelValuation.Size = new System.Drawing.Size(65, 12);
            this.labelValuation.TabIndex = 8;
            this.labelValuation.Text = "合理市值：";
            // 
            // textBoxValuation
            // 
            this.textBoxValuation.Location = new System.Drawing.Point(89, 242);
            this.textBoxValuation.Name = "textBoxValuation";
            this.textBoxValuation.Size = new System.Drawing.Size(100, 21);
            this.textBoxValuation.TabIndex = 9;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(467, 240);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 10;
            this.buttonCalculate.Text = "计算估值";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelStockPrice
            // 
            this.labelStockPrice.AutoSize = true;
            this.labelStockPrice.Location = new System.Drawing.Point(240, 245);
            this.labelStockPrice.Name = "labelStockPrice";
            this.labelStockPrice.Size = new System.Drawing.Size(65, 12);
            this.labelStockPrice.TabIndex = 12;
            this.labelStockPrice.Text = "合理股价：";
            // 
            // textBoxStockPrice
            // 
            this.textBoxStockPrice.Location = new System.Drawing.Point(311, 242);
            this.textBoxStockPrice.Name = "textBoxStockPrice";
            this.textBoxStockPrice.Size = new System.Drawing.Size(100, 21);
            this.textBoxStockPrice.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 282);
            this.Controls.Add(this.textBoxStockPrice);
            this.Controls.Add(this.labelStockPrice);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxValuation);
            this.Controls.Add(this.labelValuation);
            this.Controls.Add(this.groupBoxStage2);
            this.Controls.Add(this.groupBoxBaseData);
            this.Controls.Add(this.groupBoxStage1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "股票估值计算器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxStage1.ResumeLayout(false);
            this.groupBoxStage1.PerformLayout();
            this.groupBoxBaseData.ResumeLayout(false);
            this.groupBoxBaseData.PerformLayout();
            this.groupBoxStage2.ResumeLayout(false);
            this.groupBoxStage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStartYear1;
        private System.Windows.Forms.ComboBox comboBoxStartYear1;
        private System.Windows.Forms.Label labelEndYear1;
        private System.Windows.Forms.GroupBox groupBoxStage1;
        private System.Windows.Forms.ComboBox comboBoxGrowthRate1;
        private System.Windows.Forms.Label labelNetProfitGrowthRate1;
        private System.Windows.Forms.ComboBox comboBoxEndYear1;
        private System.Windows.Forms.ComboBox comboBoxDiscountRate;
        private System.Windows.Forms.Label labelDiscountRate;
        private System.Windows.Forms.GroupBox groupBoxBaseData;
        private System.Windows.Forms.Label labelCash;
        private System.Windows.Forms.TextBox textBoxCash;
        private System.Windows.Forms.GroupBox groupBoxStage2;
        private System.Windows.Forms.ComboBox comboBoxGrowthRate2;
        private System.Windows.Forms.Label labelNetProfitGrowthRate2;
        private System.Windows.Forms.ComboBox comboBoxEndYear2;
        private System.Windows.Forms.Label labelEndYear2;
        private System.Windows.Forms.ComboBox comboBoxStartYear2;
        private System.Windows.Forms.Label labelStartYear2;
        private System.Windows.Forms.Label labelValuation;
        private System.Windows.Forms.TextBox textBoxValuation;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelCapitalStock;
        private System.Windows.Forms.TextBox textBoxCapitalStock;
        private System.Windows.Forms.Label labelStockPrice;
        private System.Windows.Forms.TextBox textBoxStockPrice;
    }
}

