
namespace prjMedicalCenter
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAppointment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCheckAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAppointment
            // 
            this.btnAppointment.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAppointment.Location = new System.Drawing.Point(610, 200);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(122, 50);
            this.btnAppointment.TabIndex = 0;
            this.btnAppointment.Text = "網路掛號";
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(156, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "員工專區";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCheckAppointment
            // 
            this.btnCheckAppointment.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheckAppointment.Location = new System.Drawing.Point(610, 270);
            this.btnCheckAppointment.Name = "btnCheckAppointment";
            this.btnCheckAppointment.Size = new System.Drawing.Size(122, 50);
            this.btnCheckAppointment.TabIndex = 2;
            this.btnCheckAppointment.Text = "掛號查詢";
            this.btnCheckAppointment.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 572);
            this.Controls.Add(this.btnCheckAppointment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAppointment);
            this.Name = "MainForm";
            this.Text = "首頁";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCheckAppointment;
    }
}

