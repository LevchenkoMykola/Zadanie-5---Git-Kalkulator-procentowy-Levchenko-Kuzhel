namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlInputs;
        private System.Windows.Forms.Label lblPresetVessel;
        private System.Windows.Forms.ComboBox cmbPresetVessel;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.Label lblPresetSolution;
        private System.Windows.Forms.ComboBox cmbPresetSolution;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.NumericUpDown numPercentage;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Label lblResHeader;
        private System.Windows.Forms.Label lblTotalVolumeTitle;
        private System.Windows.Forms.Label lblTotalVolumeValue;
        private System.Windows.Forms.Label lblPureSubstanceTitle;
        private System.Windows.Forms.Label lblPureSubstanceValue;
        private System.Windows.Forms.Label lblError;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlInputs = new System.Windows.Forms.Panel();
            this.lblPresetVessel = new System.Windows.Forms.Label();
            this.cmbPresetVessel = new System.Windows.Forms.ComboBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.lblPresetSolution = new System.Windows.Forms.Label();
            this.cmbPresetSolution = new System.Windows.Forms.ComboBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.numPercentage = new System.Windows.Forms.NumericUpDown();
            this.lblCount = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.lblResHeader = new System.Windows.Forms.Label();
            this.lblTotalVolumeTitle = new System.Windows.Forms.Label();
            this.lblTotalVolumeValue = new System.Windows.Forms.Label();
            this.lblPureSubstanceTitle = new System.Windows.Forms.Label();
            this.lblPureSubstanceValue = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.pnlResults.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
            this.lblTitle.Location = new System.Drawing.Point(24, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 30);
            this.lblTitle.Text = "🧪 Kalkulator Substancji Czynnej";

            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblSubtitle.Location = new System.Drawing.Point(28, 52);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(360, 17);
            this.lblSubtitle.Text = "Obliczanie całkowitej objętości oraz czystej substancji w roztworze";

            // pnlInputs
            this.pnlInputs.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlInputs.Controls.Add(this.lblPresetVessel);
            this.pnlInputs.Controls.Add(this.cmbPresetVessel);
            this.pnlInputs.Controls.Add(this.lblCapacity);
            this.pnlInputs.Controls.Add(this.numCapacity);
            this.pnlInputs.Controls.Add(this.lblPresetSolution);
            this.pnlInputs.Controls.Add(this.cmbPresetSolution);
            this.pnlInputs.Controls.Add(this.lblPercentage);
            this.pnlInputs.Controls.Add(this.numPercentage);
            this.pnlInputs.Controls.Add(this.lblCount);
            this.pnlInputs.Controls.Add(this.numCount);
            this.pnlInputs.Location = new System.Drawing.Point(26, 85);
            this.pnlInputs.Name = "pnlInputs";
            this.pnlInputs.Size = new System.Drawing.Size(430, 275);

            // lblPresetVessel
            this.lblPresetVessel.AutoSize = true;
            this.lblPresetVessel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPresetVessel.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.lblPresetVessel.Location = new System.Drawing.Point(18, 16);
            this.lblPresetVessel.Text = "Typowe naczynie (opcjonalnie):";

            // cmbPresetVessel
            this.cmbPresetVessel.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.cmbPresetVessel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPresetVessel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPresetVessel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPresetVessel.ForeColor = System.Drawing.Color.White;
            this.cmbPresetVessel.Location = new System.Drawing.Point(18, 38);
            this.cmbPresetVessel.Name = "cmbPresetVessel";
            this.cmbPresetVessel.Size = new System.Drawing.Size(230, 25);

            // lblCapacity
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCapacity.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.lblCapacity.Location = new System.Drawing.Point(265, 16);
            this.lblCapacity.Text = "Pojemność [ml]:";

            // numCapacity
            this.numCapacity.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.numCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCapacity.DecimalPlaces = 1;
            this.numCapacity.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.numCapacity.ForeColor = System.Drawing.Color.White;
            this.numCapacity.Location = new System.Drawing.Point(265, 38);
            this.numCapacity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(145, 26);
            this.numCapacity.Value = new decimal(new int[] { 50, 0, 0, 0 });

            // lblPresetSolution
            this.lblPresetSolution.AutoSize = true;
            this.lblPresetSolution.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPresetSolution.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.lblPresetSolution.Location = new System.Drawing.Point(18, 86);
            this.lblPresetSolution.Text = "Typowy roztwór (opcjonalnie):";

            // cmbPresetSolution
            this.cmbPresetSolution.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.cmbPresetSolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPresetSolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPresetSolution.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPresetSolution.ForeColor = System.Drawing.Color.White;
            this.cmbPresetSolution.Location = new System.Drawing.Point(18, 108);
            this.cmbPresetSolution.Name = "cmbPresetSolution";
            this.cmbPresetSolution.Size = new System.Drawing.Size(230, 25);

            // lblPercentage
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPercentage.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.lblPercentage.Location = new System.Drawing.Point(265, 86);
            this.lblPercentage.Text = "Zawartość [%]:";

            // numPercentage
            this.numPercentage.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.numPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numPercentage.DecimalPlaces = 2;
            this.numPercentage.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.numPercentage.ForeColor = System.Drawing.Color.White;
            this.numPercentage.Location = new System.Drawing.Point(265, 108);
            this.numPercentage.Name = "numPercentage";
            this.numPercentage.Size = new System.Drawing.Size(145, 26);
            this.numPercentage.Value = new decimal(new int[] { 40, 0, 0, 0 });

            // lblCount
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.lblCount.Location = new System.Drawing.Point(18, 165);
            this.lblCount.Text = "Liczba sztuk naczyń [szt.]:";

            // numCount
            this.numCount.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.numCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.numCount.ForeColor = System.Drawing.Color.White;
            this.numCount.Location = new System.Drawing.Point(18, 190);
            this.numCount.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(392, 27);
            this.numCount.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // btnCalculate
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(14, 165, 233);
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(26, 375);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(295, 42);
            this.btnCalculate.Text = "OBLICZ WYNIK";
            this.btnCalculate.UseVisualStyleBackColor = false;

            // btnReset
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnReset.Location = new System.Drawing.Point(331, 375);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 42);
            this.btnReset.Text = "Wyczyść";
            this.btnReset.UseVisualStyleBackColor = false;

            // pnlResults
            this.pnlResults.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlResults.Controls.Add(this.lblResHeader);
            this.pnlResults.Controls.Add(this.lblTotalVolumeTitle);
            this.pnlResults.Controls.Add(this.lblTotalVolumeValue);
            this.pnlResults.Controls.Add(this.lblPureSubstanceTitle);
            this.pnlResults.Controls.Add(this.lblPureSubstanceValue);
            this.pnlResults.Location = new System.Drawing.Point(26, 432);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(430, 130);

            // lblResHeader
            this.lblResHeader.AutoSize = true;
            this.lblResHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblResHeader.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblResHeader.Location = new System.Drawing.Point(18, 12);
            this.lblResHeader.Text = "WYNIKI OBLICZEŃ";

            // lblTotalVolumeTitle
            this.lblTotalVolumeTitle.AutoSize = true;
            this.lblTotalVolumeTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalVolumeTitle.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.lblTotalVolumeTitle.Location = new System.Drawing.Point(18, 45);
            this.lblTotalVolumeTitle.Text = "Łączna objętość płynu:";

            // lblTotalVolumeValue
            this.lblTotalVolumeValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalVolumeValue.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
            this.lblTotalVolumeValue.Location = new System.Drawing.Point(210, 42);
            this.lblTotalVolumeValue.Size = new System.Drawing.Size(200, 25);
            this.lblTotalVolumeValue.Text = "0.00 ml";
            this.lblTotalVolumeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblPureSubstanceTitle
            this.lblPureSubstanceTitle.AutoSize = true;
            this.lblPureSubstanceTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPureSubstanceTitle.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.lblPureSubstanceTitle.Location = new System.Drawing.Point(18, 85);
            this.lblPureSubstanceTitle.Text = "Czysta substancja czynna:";

            // lblPureSubstanceValue
            this.lblPureSubstanceValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPureSubstanceValue.ForeColor = System.Drawing.Color.FromArgb(52, 211, 153);
            this.lblPureSubstanceValue.Location = new System.Drawing.Point(210, 81);
            this.lblPureSubstanceValue.Size = new System.Drawing.Size(200, 28);
            this.lblPureSubstanceValue.Text = "0.00 ml";
            this.lblPureSubstanceValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblError
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(248, 113, 113);
            this.lblError.Location = new System.Drawing.Point(26, 568);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.ClientSize = new System.Drawing.Size(482, 595);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.pnlInputs);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.lblError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator Roztworów — Zadanie 3";
            this.pnlInputs.ResumeLayout(false);
            this.pnlInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}