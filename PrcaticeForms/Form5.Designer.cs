namespace PrcaticeForms
{
    partial class Form5
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
        public void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.txtEnterUnits = new System.Windows.Forms.TextBox();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.lblEnterUnits = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt100hundred = new System.Windows.Forms.TextBox();
            this.txt200twohundred = new System.Windows.Forms.TextBox();
            this.txt_400equalfourhundred = new System.Windows.Forms.TextBox();
            this.txt400fourhundred = new System.Windows.Forms.TextBox();
            this.txtFPPPACharge = new System.Windows.Forms.TextBox();
            this.txt50fifty = new System.Windows.Forms.TextBox();
            this.grpGovTax = new System.Windows.Forms.GroupBox();
            this.rdo10per = new System.Windows.Forms.RadioButton();
            this.rdo25per = new System.Windows.Forms.RadioButton();
            this.rdo15per = new System.Windows.Forms.RadioButton();
            this.rdo20per = new System.Windows.Forms.RadioButton();
            this.grpFixCharges = new System.Windows.Forms.GroupBox();
            this.rdo10rupees = new System.Windows.Forms.RadioButton();
            this.rdo25rupees = new System.Windows.Forms.RadioButton();
            this.rdo15rupees = new System.Windows.Forms.RadioButton();
            this.rdo20rupees = new System.Windows.Forms.RadioButton();
            this.lbl_400 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl400 = new System.Windows.Forms.Label();
            this.lbl200 = new System.Windows.Forms.Label();
            this.lbl100 = new System.Windows.Forms.Label();
            this.lbl50 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpGovTax.SuspendLayout();
            this.grpFixCharges.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 20);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 534);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtBillAmount);
            this.tabPage1.Controls.Add(this.txtEnterUnits);
            this.tabPage1.Controls.Add(this.lblBillAmount);
            this.tabPage1.Controls.Add(this.lblEnterUnits);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillAmount.Location = new System.Drawing.Point(48, 294);
            this.txtBillAmount.MaxLength = 20;
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.ReadOnly = true;
            this.txtBillAmount.Size = new System.Drawing.Size(319, 38);
            this.txtBillAmount.TabIndex = 30;
            this.txtBillAmount.TabStop = false;
            this.txtBillAmount.Text = "0";
            this.txtBillAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEnterUnits
            // 
            this.txtEnterUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterUnits.Location = new System.Drawing.Point(48, 118);
            this.txtEnterUnits.MaxLength = 19;
            this.txtEnterUnits.Name = "txtEnterUnits";
            this.txtEnterUnits.Size = new System.Drawing.Size(319, 38);
            this.txtEnterUnits.TabIndex = 1;
            this.txtEnterUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEnterUnits.TextChanged += new System.EventHandler(this.getUserValue);
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillAmount.Location = new System.Drawing.Point(42, 216);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(150, 31);
            this.lblBillAmount.TabIndex = 1;
            this.lblBillAmount.Text = "Bill Amount";
            // 
            // lblEnterUnits
            // 
            this.lblEnterUnits.AutoSize = true;
            this.lblEnterUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterUnits.Location = new System.Drawing.Point(42, 54);
            this.lblEnterUnits.Name = "lblEnterUnits";
            this.lblEnterUnits.Size = new System.Drawing.Size(149, 31);
            this.lblEnterUnits.TabIndex = 0;
            this.lblEnterUnits.Text = "Enter Units";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt100hundred);
            this.tabPage2.Controls.Add(this.txt200twohundred);
            this.tabPage2.Controls.Add(this.txt_400equalfourhundred);
            this.tabPage2.Controls.Add(this.txt400fourhundred);
            this.tabPage2.Controls.Add(this.txtFPPPACharge);
            this.tabPage2.Controls.Add(this.txt50fifty);
            this.tabPage2.Controls.Add(this.grpGovTax);
            this.tabPage2.Controls.Add(this.grpFixCharges);
            this.tabPage2.Controls.Add(this.lbl_400);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lbl400);
            this.tabPage2.Controls.Add(this.lbl200);
            this.tabPage2.Controls.Add(this.lbl100);
            this.tabPage2.Controls.Add(this.lbl50);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(632, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt100hundred
            // 
            this.txt100hundred.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt100hundred.Location = new System.Drawing.Point(189, 52);
            this.txt100hundred.Name = "txt100hundred";
            this.txt100hundred.Size = new System.Drawing.Size(100, 26);
            this.txt100hundred.TabIndex = 2;
            this.txt100hundred.Text = "3.25";
            this.txt100hundred.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt100hundred.TextChanged += new System.EventHandler(this.getUserValue);
            // 
            // txt200twohundred
            // 
            this.txt200twohundred.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt200twohundred.Location = new System.Drawing.Point(189, 91);
            this.txt200twohundred.Name = "txt200twohundred";
            this.txt200twohundred.Size = new System.Drawing.Size(100, 26);
            this.txt200twohundred.TabIndex = 3;
            this.txt200twohundred.Text = "3.50";
            this.txt200twohundred.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt200twohundred.TextChanged += new System.EventHandler(this.getUserValue);
            // 
            // txt_400equalfourhundred
            // 
            this.txt_400equalfourhundred.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_400equalfourhundred.Location = new System.Drawing.Point(189, 129);
            this.txt_400equalfourhundred.Name = "txt_400equalfourhundred";
            this.txt_400equalfourhundred.Size = new System.Drawing.Size(100, 26);
            this.txt_400equalfourhundred.TabIndex = 4;
            this.txt_400equalfourhundred.Text = "4.00";
            this.txt_400equalfourhundred.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_400equalfourhundred.TextChanged += new System.EventHandler(this.getUserValue);
            // 
            // txt400fourhundred
            // 
            this.txt400fourhundred.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt400fourhundred.Location = new System.Drawing.Point(189, 166);
            this.txt400fourhundred.Name = "txt400fourhundred";
            this.txt400fourhundred.Size = new System.Drawing.Size(100, 26);
            this.txt400fourhundred.TabIndex = 5;
            this.txt400fourhundred.Text = "4.50";
            this.txt400fourhundred.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt400fourhundred.TextChanged += new System.EventHandler(this.getUserValue);
            // 
            // txtFPPPACharge
            // 
            this.txtFPPPACharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFPPPACharge.Location = new System.Drawing.Point(189, 234);
            this.txtFPPPACharge.Name = "txtFPPPACharge";
            this.txtFPPPACharge.Size = new System.Drawing.Size(100, 26);
            this.txtFPPPACharge.TabIndex = 6;
            this.txtFPPPACharge.Text = "1.80";
            this.txtFPPPACharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFPPPACharge.TextChanged += new System.EventHandler(this.getUserValue);
            // 
            // txt50fifty
            // 
            this.txt50fifty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt50fifty.Location = new System.Drawing.Point(189, 15);
            this.txt50fifty.Name = "txt50fifty";
            this.txt50fifty.Size = new System.Drawing.Size(100, 26);
            this.txt50fifty.TabIndex = 1;
            this.txt50fifty.Text = "3.05";
            this.txt50fifty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt50fifty.WordWrap = false;
            this.txt50fifty.TextChanged += new System.EventHandler(this.getUserValue);
            // 
            // grpGovTax
            // 
            this.grpGovTax.AutoSize = true;
            this.grpGovTax.Controls.Add(this.rdo10per);
            this.grpGovTax.Controls.Add(this.rdo25per);
            this.grpGovTax.Controls.Add(this.rdo15per);
            this.grpGovTax.Controls.Add(this.rdo20per);
            this.grpGovTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGovTax.Location = new System.Drawing.Point(65, 374);
            this.grpGovTax.Name = "grpGovTax";
            this.grpGovTax.Size = new System.Drawing.Size(423, 84);
            this.grpGovTax.TabIndex = 13;
            this.grpGovTax.TabStop = false;
            this.grpGovTax.Text = "Gov. Tax";
            // 
            // rdo10per
            // 
            this.rdo10per.AutoSize = true;
            this.rdo10per.Checked = true;
            this.rdo10per.Location = new System.Drawing.Point(6, 35);
            this.rdo10per.Name = "rdo10per";
            this.rdo10per.Size = new System.Drawing.Size(59, 24);
            this.rdo10per.TabIndex = 8;
            this.rdo10per.TabStop = true;
            this.rdo10per.Text = "10%";
            this.rdo10per.UseVisualStyleBackColor = true;
            this.rdo10per.Click += new System.EventHandler(this.getUserValue);
            // 
            // rdo25per
            // 
            this.rdo25per.AutoSize = true;
            this.rdo25per.Location = new System.Drawing.Point(279, 35);
            this.rdo25per.Name = "rdo25per";
            this.rdo25per.Size = new System.Drawing.Size(59, 24);
            this.rdo25per.TabIndex = 11;
            this.rdo25per.Text = "25%";
            this.rdo25per.UseVisualStyleBackColor = true;
            this.rdo25per.Click += new System.EventHandler(this.getUserValue);
            // 
            // rdo15per
            // 
            this.rdo15per.AutoSize = true;
            this.rdo15per.Location = new System.Drawing.Point(97, 35);
            this.rdo15per.Name = "rdo15per";
            this.rdo15per.Size = new System.Drawing.Size(59, 24);
            this.rdo15per.TabIndex = 9;
            this.rdo15per.Text = "15%";
            this.rdo15per.UseVisualStyleBackColor = true;
            this.rdo15per.Click += new System.EventHandler(this.getUserValue);
            // 
            // rdo20per
            // 
            this.rdo20per.AutoSize = true;
            this.rdo20per.Location = new System.Drawing.Point(188, 35);
            this.rdo20per.Name = "rdo20per";
            this.rdo20per.Size = new System.Drawing.Size(59, 24);
            this.rdo20per.TabIndex = 10;
            this.rdo20per.Text = "20%";
            this.rdo20per.UseVisualStyleBackColor = true;
            this.rdo20per.Click += new System.EventHandler(this.getUserValue);
            // 
            // grpFixCharges
            // 
            this.grpFixCharges.AutoSize = true;
            this.grpFixCharges.Controls.Add(this.rdo10rupees);
            this.grpFixCharges.Controls.Add(this.rdo25rupees);
            this.grpFixCharges.Controls.Add(this.rdo15rupees);
            this.grpFixCharges.Controls.Add(this.rdo20rupees);
            this.grpFixCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFixCharges.Location = new System.Drawing.Point(65, 284);
            this.grpFixCharges.Name = "grpFixCharges";
            this.grpFixCharges.Size = new System.Drawing.Size(429, 84);
            this.grpFixCharges.TabIndex = 12;
            this.grpFixCharges.TabStop = false;
            this.grpFixCharges.Text = "Fix Charges";
            // 
            // rdo10rupees
            // 
            this.rdo10rupees.AutoSize = true;
            this.rdo10rupees.Checked = true;
            this.rdo10rupees.Location = new System.Drawing.Point(6, 35);
            this.rdo10rupees.Name = "rdo10rupees";
            this.rdo10rupees.Size = new System.Drawing.Size(54, 24);
            this.rdo10rupees.TabIndex = 8;
            this.rdo10rupees.TabStop = true;
            this.rdo10rupees.Text = "10/-";
            this.rdo10rupees.UseVisualStyleBackColor = true;
            this.rdo10rupees.Click += new System.EventHandler(this.getUserValue);
            // 
            // rdo25rupees
            // 
            this.rdo25rupees.AutoSize = true;
            this.rdo25rupees.Location = new System.Drawing.Point(279, 35);
            this.rdo25rupees.Name = "rdo25rupees";
            this.rdo25rupees.Size = new System.Drawing.Size(54, 24);
            this.rdo25rupees.TabIndex = 11;
            this.rdo25rupees.Text = "25/-";
            this.rdo25rupees.UseVisualStyleBackColor = true;
            this.rdo25rupees.Click += new System.EventHandler(this.getUserValue);
            // 
            // rdo15rupees
            // 
            this.rdo15rupees.AutoSize = true;
            this.rdo15rupees.Location = new System.Drawing.Point(97, 35);
            this.rdo15rupees.Name = "rdo15rupees";
            this.rdo15rupees.Size = new System.Drawing.Size(54, 24);
            this.rdo15rupees.TabIndex = 9;
            this.rdo15rupees.Text = "15/-";
            this.rdo15rupees.UseVisualStyleBackColor = true;
            this.rdo15rupees.Click += new System.EventHandler(this.getUserValue);
            // 
            // rdo20rupees
            // 
            this.rdo20rupees.AutoSize = true;
            this.rdo20rupees.Location = new System.Drawing.Point(188, 35);
            this.rdo20rupees.Name = "rdo20rupees";
            this.rdo20rupees.Size = new System.Drawing.Size(54, 24);
            this.rdo20rupees.TabIndex = 10;
            this.rdo20rupees.Text = "20/-";
            this.rdo20rupees.UseVisualStyleBackColor = true;
            this.rdo20rupees.Click += new System.EventHandler(this.getUserValue);
            // 
            // lbl_400
            // 
            this.lbl_400.AutoSize = true;
            this.lbl_400.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_400.Location = new System.Drawing.Point(61, 132);
            this.lbl_400.Name = "lbl_400";
            this.lbl_400.Size = new System.Drawing.Size(95, 20);
            this.lbl_400.TabIndex = 7;
            this.lbl_400.Text = "<=400 Units";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "FPPPA Charge";
            // 
            // lbl400
            // 
            this.lbl400.AutoSize = true;
            this.lbl400.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl400.Location = new System.Drawing.Point(61, 169);
            this.lbl400.Name = "lbl400";
            this.lbl400.Size = new System.Drawing.Size(86, 20);
            this.lbl400.TabIndex = 3;
            this.lbl400.Text = ">400 Units";
            // 
            // lbl200
            // 
            this.lbl200.AutoSize = true;
            this.lbl200.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl200.Location = new System.Drawing.Point(61, 94);
            this.lbl200.Name = "lbl200";
            this.lbl200.Size = new System.Drawing.Size(86, 20);
            this.lbl200.TabIndex = 2;
            this.lbl200.Text = "<200 Units";
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl100.Location = new System.Drawing.Point(61, 55);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(86, 20);
            this.lbl100.TabIndex = 1;
            this.lbl100.Text = "<100 Units";
            // 
            // lbl50
            // 
            this.lbl50.AutoSize = true;
            this.lbl50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl50.Location = new System.Drawing.Point(61, 18);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(77, 20);
            this.lbl50.TabIndex = 0;
            this.lbl50.Text = "<50 Units";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(7, 538);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 59);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(496, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            //this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(644, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grpGovTax.ResumeLayout(false);
            this.grpGovTax.PerformLayout();
            this.grpFixCharges.ResumeLayout(false);
            this.grpFixCharges.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblEnterUnits;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.TextBox txtEnterUnits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl400;
        private System.Windows.Forms.Label lbl200;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.Label lbl50;
        private System.Windows.Forms.Label lbl_400;
        private System.Windows.Forms.RadioButton rdo15rupees;
        private System.Windows.Forms.RadioButton rdo10rupees;
        private System.Windows.Forms.GroupBox grpFixCharges;
        private System.Windows.Forms.RadioButton rdo25rupees;
        private System.Windows.Forms.RadioButton rdo20rupees;
        private System.Windows.Forms.GroupBox grpGovTax;
        private System.Windows.Forms.RadioButton rdo10per;
        private System.Windows.Forms.RadioButton rdo25per;
        private System.Windows.Forms.RadioButton rdo15per;
        private System.Windows.Forms.RadioButton rdo20per;
        private System.Windows.Forms.TextBox txt100hundred;
        private System.Windows.Forms.TextBox txt200twohundred;
        private System.Windows.Forms.TextBox txt_400equalfourhundred;
        private System.Windows.Forms.TextBox txt400fourhundred;
        private System.Windows.Forms.TextBox txtFPPPACharge;
        private System.Windows.Forms.TextBox txt50fifty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
    }
}