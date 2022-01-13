
namespace BitCoinCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyMenu = new System.Windows.Forms.ComboBox();
            this.getRatesBTN = new System.Windows.Forms.Button();
            this.amountOfBC = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.resultLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencyMenu
            // 
            this.currencyMenu.FormattingEnabled = true;
            this.currencyMenu.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.currencyMenu.Location = new System.Drawing.Point(406, 68);
            this.currencyMenu.Name = "currencyMenu";
            this.currencyMenu.Size = new System.Drawing.Size(121, 21);
            this.currencyMenu.TabIndex = 0;
            this.currencyMenu.Text = "Select Currency";
            // 
            // getRatesBTN
            // 
            this.getRatesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getRatesBTN.Location = new System.Drawing.Point(533, 111);
            this.getRatesBTN.Name = "getRatesBTN";
            this.getRatesBTN.Size = new System.Drawing.Size(75, 23);
            this.getRatesBTN.TabIndex = 1;
            this.getRatesBTN.Text = "Get Rates";
            this.getRatesBTN.UseVisualStyleBackColor = true;
            this.getRatesBTN.Click += new System.EventHandler(this.getRatesBTN_Click);
            // 
            // amountOfBC
            // 
            this.amountOfBC.Location = new System.Drawing.Point(406, 114);
            this.amountOfBC.Name = "amountOfBC";
            this.amountOfBC.Size = new System.Drawing.Size(121, 20);
            this.amountOfBC.TabIndex = 2;
            this.amountOfBC.Tag = "";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(406, 208);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 3;
            this.result.Visible = false;
            // 
            // resultLBL
            // 
            this.resultLBL.AutoSize = true;
            this.resultLBL.Location = new System.Drawing.Point(412, 192);
            this.resultLBL.Name = "resultLBL";
            this.resultLBL.Size = new System.Drawing.Size(37, 13);
            this.resultLBL.TabIndex = 4;
            this.resultLBL.Text = "Result";
            this.resultLBL.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(647, 418);
            this.Controls.Add(this.resultLBL);
            this.Controls.Add(this.result);
            this.Controls.Add(this.amountOfBC);
            this.Controls.Add(this.getRatesBTN);
            this.Controls.Add(this.currencyMenu);
            this.Name = "Form1";
            this.Text = "BitCoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyMenu;
        private System.Windows.Forms.Button getRatesBTN;
        private System.Windows.Forms.TextBox amountOfBC;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label resultLBL;
    }
}

