
namespace prjMedicalCenter
{
    partial class FormPersonalAppointmentInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonPassportNumber = new System.Windows.Forms.RadioButton();
            this.radioButtonMedicalRecordNumber = new System.Windows.Forms.RadioButton();
            this.radioButtonIDNumber = new System.Windows.Forms.RadioButton();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxDOB = new System.Windows.Forms.TextBox();
            this.textBoxVerification = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelVerification = new System.Windows.Forms.Label();
            this.labelRefreshVerification = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入個人門診掛號資料";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(609, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "複診: 請擇一輸入身分證字號、病歷號、護照號碼，並請確實填寫。";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(7, 2);
            this.linkLabel1.Location = new System.Drawing.Point(29, 101);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(339, 29);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "初診: 請點此連結輸入個人初診資料。";
            this.linkLabel1.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonPassportNumber);
            this.panel1.Controls.Add(this.radioButtonMedicalRecordNumber);
            this.panel1.Controls.Add(this.radioButtonIDNumber);
            this.panel1.Location = new System.Drawing.Point(29, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 38);
            this.panel1.TabIndex = 4;
            // 
            // radioButtonPassportNumber
            // 
            this.radioButtonPassportNumber.AutoSize = true;
            this.radioButtonPassportNumber.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButtonPassportNumber.Location = new System.Drawing.Point(229, 3);
            this.radioButtonPassportNumber.Name = "radioButtonPassportNumber";
            this.radioButtonPassportNumber.Size = new System.Drawing.Size(107, 23);
            this.radioButtonPassportNumber.TabIndex = 2;
            this.radioButtonPassportNumber.TabStop = true;
            this.radioButtonPassportNumber.Text = "護照號碼";
            this.radioButtonPassportNumber.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedicalRecordNumber
            // 
            this.radioButtonMedicalRecordNumber.AutoSize = true;
            this.radioButtonMedicalRecordNumber.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButtonMedicalRecordNumber.Location = new System.Drawing.Point(136, 3);
            this.radioButtonMedicalRecordNumber.Name = "radioButtonMedicalRecordNumber";
            this.radioButtonMedicalRecordNumber.Size = new System.Drawing.Size(87, 23);
            this.radioButtonMedicalRecordNumber.TabIndex = 1;
            this.radioButtonMedicalRecordNumber.TabStop = true;
            this.radioButtonMedicalRecordNumber.Text = "病歷號";
            this.radioButtonMedicalRecordNumber.UseVisualStyleBackColor = true;
            // 
            // radioButtonIDNumber
            // 
            this.radioButtonIDNumber.AutoSize = true;
            this.radioButtonIDNumber.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButtonIDNumber.Location = new System.Drawing.Point(3, 3);
            this.radioButtonIDNumber.Name = "radioButtonIDNumber";
            this.radioButtonIDNumber.Size = new System.Drawing.Size(127, 23);
            this.radioButtonIDNumber.TabIndex = 0;
            this.radioButtonIDNumber.TabStop = true;
            this.radioButtonIDNumber.Text = "身分證字號";
            this.radioButtonIDNumber.UseVisualStyleBackColor = true;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.ForeColor = System.Drawing.Color.Gray;
            this.textBoxID.Location = new System.Drawing.Point(29, 192);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(317, 30);
            this.textBoxID.TabIndex = 5;
            this.textBoxID.Text = "請輸入證號";
            this.textBoxID.Enter += new System.EventHandler(this.textBoxID_Enter);
            this.textBoxID.Leave += new System.EventHandler(this.textBoxID_Leave);
            // 
            // textBoxDOB
            // 
            this.textBoxDOB.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDOB.ForeColor = System.Drawing.Color.Gray;
            this.textBoxDOB.Location = new System.Drawing.Point(29, 233);
            this.textBoxDOB.Name = "textBoxDOB";
            this.textBoxDOB.Size = new System.Drawing.Size(317, 30);
            this.textBoxDOB.TabIndex = 6;
            this.textBoxDOB.Text = "請輸入生日(西元年、月、日)";
            this.textBoxDOB.Enter += new System.EventHandler(this.textBoxDOB_Enter);
            this.textBoxDOB.Leave += new System.EventHandler(this.textBoxDOB_Leave);
            // 
            // textBoxVerification
            // 
            this.textBoxVerification.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVerification.ForeColor = System.Drawing.Color.Gray;
            this.textBoxVerification.Location = new System.Drawing.Point(29, 274);
            this.textBoxVerification.Name = "textBoxVerification";
            this.textBoxVerification.Size = new System.Drawing.Size(317, 29);
            this.textBoxVerification.TabIndex = 7;
            this.textBoxVerification.Text = "請輸入驗證碼";
            this.textBoxVerification.Enter += new System.EventHandler(this.textBoxVerification_Enter);
            this.textBoxVerification.Leave += new System.EventHandler(this.textBoxVerification_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(348, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "(範例：出生日期為1987年01月26日，請輸入19870126)";
            // 
            // labelVerification
            // 
            this.labelVerification.AutoSize = true;
            this.labelVerification.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerification.Location = new System.Drawing.Point(352, 276);
            this.labelVerification.Name = "labelVerification";
            this.labelVerification.Size = new System.Drawing.Size(69, 24);
            this.labelVerification.TabIndex = 12;
            this.labelVerification.Text = "label4";
            // 
            // labelRefreshVerification
            // 
            this.labelRefreshVerification.AutoSize = true;
            this.labelRefreshVerification.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelRefreshVerification.Location = new System.Drawing.Point(423, 279);
            this.labelRefreshVerification.Name = "labelRefreshVerification";
            this.labelRefreshVerification.Size = new System.Drawing.Size(89, 19);
            this.labelRefreshVerification.TabIndex = 13;
            this.labelRefreshVerification.Text = "點擊刷新";
            this.labelRefreshVerification.Click += new System.EventHandler(this.labelRefreshVerification_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(258, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "掛號";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(427, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 39);
            this.button2.TabIndex = 15;
            this.button2.Text = "重新填寫";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormPersonalAppointmentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelRefreshVerification);
            this.Controls.Add(this.labelVerification);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxVerification);
            this.Controls.Add(this.textBoxDOB);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPersonalAppointmentInfo";
            this.Text = "FormPersonalAppointmentInfo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPersonalAppointmentInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonPassportNumber;
        private System.Windows.Forms.RadioButton radioButtonMedicalRecordNumber;
        private System.Windows.Forms.RadioButton radioButtonIDNumber;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxDOB;
        private System.Windows.Forms.TextBox textBoxVerification;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelVerification;
        private System.Windows.Forms.Label labelRefreshVerification;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}