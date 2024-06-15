namespace Grafes_if
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
            this.components = new System.ComponentModel.Container();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxGrade = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblDataError = new System.Windows.Forms.Label();
            this.DataErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(263, 47);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(142, 20);
            this.txtGrade.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(263, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(263, 31);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(36, 13);
            this.lblGrade.TabIndex = 3;
            this.lblGrade.Text = "Grade";
            this.lblGrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbxGrade
            // 
            this.lbxGrade.FormattingEnabled = true;
            this.lbxGrade.Location = new System.Drawing.Point(38, 141);
            this.lbxGrade.Name = "lbxGrade";
            this.lbxGrade.Size = new System.Drawing.Size(218, 186);
            this.lbxGrade.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(38, 31);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(218, 92);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate This";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblDataError
            // 
            this.lblDataError.BackColor = System.Drawing.Color.Yellow;
            this.lblDataError.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataError.ForeColor = System.Drawing.Color.Red;
            this.lblDataError.Location = new System.Drawing.Point(288, 154);
            this.lblDataError.Name = "lblDataError";
            this.lblDataError.Size = new System.Drawing.Size(116, 162);
            this.lblDataError.TabIndex = 7;
            this.lblDataError.Text = "label2";
            this.lblDataError.Visible = false;
            // 
            // DataErrorProvider
            // 
            this.DataErrorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 341);
            this.Controls.Add(this.lblDataError);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbxGrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtGrade);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxGrade;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblDataError;
        private System.Windows.Forms.ErrorProvider DataErrorProvider;
    }
}

