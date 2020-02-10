namespace parking_lot_winform
{
    partial class Form1
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
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtpTime_start = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTime_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.start_button = new System.Windows.Forms.Button();
            this.outDisply = new System.Windows.Forms.Panel();
            this.restart_button = new System.Windows.Forms.Button();
            this.speedUp6 = new System.Windows.Forms.Button();
            this.speedUp5 = new System.Windows.Forms.Button();
            this.speedUp4 = new System.Windows.Forms.Button();
            this.speedUp3 = new System.Windows.Forms.Button();
            this.speedUp1 = new System.Windows.Forms.Button();
            this.speedUp2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.regulation_display = new System.Windows.Forms.RichTextBox();
            this.cost_display = new System.Windows.Forms.RichTextBox();
            this.pay_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.outDisply.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_start
            // 
            this.dtp_start.CustomFormat = "dd/mm/yyyy hh:mm:ss";
            this.dtp_start.Enabled = false;
            this.dtp_start.Location = new System.Drawing.Point(14, 34);
            this.dtp_start.Margin = new System.Windows.Forms.Padding(5);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(168, 29);
            this.dtp_start.TabIndex = 0;
            // 
            // dtpTime_start
            // 
            this.dtpTime_start.CustomFormat = " hh:mm:ss";
            this.dtpTime_start.Enabled = false;
            this.dtpTime_start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime_start.Location = new System.Drawing.Point(14, 73);
            this.dtpTime_start.Margin = new System.Windows.Forms.Padding(5);
            this.dtpTime_start.Name = "dtpTime_start";
            this.dtpTime_start.ShowUpDown = true;
            this.dtpTime_start.Size = new System.Drawing.Size(133, 29);
            this.dtpTime_start.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "入場時間:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "出場時間:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpTime_end
            // 
            this.dtpTime_end.CustomFormat = " hh:mm:ss";
            this.dtpTime_end.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime_end.Location = new System.Drawing.Point(14, 73);
            this.dtpTime_end.Margin = new System.Windows.Forms.Padding(5);
            this.dtpTime_end.Name = "dtpTime_end";
            this.dtpTime_end.ShowUpDown = true;
            this.dtpTime_end.Size = new System.Drawing.Size(133, 29);
            this.dtpTime_end.TabIndex = 4;
            // 
            // dtp_end
            // 
            this.dtp_end.CustomFormat = "dd/mm/yyyy hh:mm:ss";
            this.dtp_end.Location = new System.Drawing.Point(14, 34);
            this.dtp_end.Margin = new System.Windows.Forms.Padding(5);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(168, 29);
            this.dtp_end.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.start_button);
            this.panel1.Controls.Add(this.dtp_start);
            this.panel1.Controls.Add(this.dtpTime_start);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.outDisply);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 357);
            this.panel1.TabIndex = 6;
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(94, 3);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(89, 26);
            this.start_button.TabIndex = 9;
            this.start_button.Text = "開始計費";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // outDisply
            // 
            this.outDisply.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outDisply.Controls.Add(this.restart_button);
            this.outDisply.Controls.Add(this.speedUp6);
            this.outDisply.Controls.Add(this.label2);
            this.outDisply.Controls.Add(this.speedUp5);
            this.outDisply.Controls.Add(this.dtp_end);
            this.outDisply.Controls.Add(this.speedUp4);
            this.outDisply.Controls.Add(this.dtpTime_end);
            this.outDisply.Controls.Add(this.speedUp3);
            this.outDisply.Controls.Add(this.speedUp1);
            this.outDisply.Controls.Add(this.speedUp2);
            this.outDisply.Controls.Add(this.label3);
            this.outDisply.Location = new System.Drawing.Point(-1, 110);
            this.outDisply.Name = "outDisply";
            this.outDisply.Size = new System.Drawing.Size(207, 246);
            this.outDisply.TabIndex = 17;
            // 
            // restart_button
            // 
            this.restart_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restart_button.Location = new System.Drawing.Point(62, 213);
            this.restart_button.Name = "restart_button";
            this.restart_button.Size = new System.Drawing.Size(85, 28);
            this.restart_button.TabIndex = 11;
            this.restart_button.Text = "重新開始";
            this.restart_button.UseVisualStyleBackColor = true;
            this.restart_button.Click += new System.EventHandler(this.restart_button_Click);
            // 
            // speedUp6
            // 
            this.speedUp6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speedUp6.Location = new System.Drawing.Point(139, 165);
            this.speedUp6.Name = "speedUp6";
            this.speedUp6.Size = new System.Drawing.Size(59, 29);
            this.speedUp6.TabIndex = 16;
            this.speedUp6.Text = "1周";
            this.speedUp6.UseVisualStyleBackColor = true;
            // 
            // speedUp5
            // 
            this.speedUp5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speedUp5.Location = new System.Drawing.Point(77, 165);
            this.speedUp5.Name = "speedUp5";
            this.speedUp5.Size = new System.Drawing.Size(56, 29);
            this.speedUp5.TabIndex = 15;
            this.speedUp5.Text = "1天";
            this.speedUp5.UseVisualStyleBackColor = true;
            // 
            // speedUp4
            // 
            this.speedUp4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speedUp4.Location = new System.Drawing.Point(9, 165);
            this.speedUp4.Name = "speedUp4";
            this.speedUp4.Size = new System.Drawing.Size(62, 29);
            this.speedUp4.TabIndex = 14;
            this.speedUp4.Text = "1小時";
            this.speedUp4.UseVisualStyleBackColor = true;
            // 
            // speedUp3
            // 
            this.speedUp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speedUp3.Location = new System.Drawing.Point(139, 130);
            this.speedUp3.Name = "speedUp3";
            this.speedUp3.Size = new System.Drawing.Size(59, 29);
            this.speedUp3.TabIndex = 13;
            this.speedUp3.Text = "30分";
            this.speedUp3.UseVisualStyleBackColor = true;
            // 
            // speedUp1
            // 
            this.speedUp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speedUp1.Location = new System.Drawing.Point(9, 130);
            this.speedUp1.Name = "speedUp1";
            this.speedUp1.Size = new System.Drawing.Size(53, 29);
            this.speedUp1.TabIndex = 10;
            this.speedUp1.Text = "5分";
            this.speedUp1.UseVisualStyleBackColor = true;
            // 
            // speedUp2
            // 
            this.speedUp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speedUp2.Location = new System.Drawing.Point(68, 130);
            this.speedUp2.Name = "speedUp2";
            this.speedUp2.Size = new System.Drawing.Size(65, 29);
            this.speedUp2.TabIndex = 12;
            this.speedUp2.Text = "10分";
            this.speedUp2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "加速:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // regulation_display
            // 
            this.regulation_display.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.regulation_display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regulation_display.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.regulation_display.ForeColor = System.Drawing.SystemColors.WindowText;
            this.regulation_display.Location = new System.Drawing.Point(225, 10);
            this.regulation_display.Name = "regulation_display";
            this.regulation_display.ReadOnly = true;
            this.regulation_display.Size = new System.Drawing.Size(310, 175);
            this.regulation_display.TabIndex = 8;
            this.regulation_display.Text = "";
            // 
            // cost_display
            // 
            this.cost_display.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cost_display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cost_display.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cost_display.Location = new System.Drawing.Point(225, 220);
            this.cost_display.Name = "cost_display";
            this.cost_display.ReadOnly = true;
            this.cost_display.Size = new System.Drawing.Size(310, 147);
            this.cost_display.TabIndex = 9;
            this.cost_display.Text = "";
            // 
            // pay_button
            // 
            this.pay_button.Location = new System.Drawing.Point(334, 188);
            this.pay_button.Name = "pay_button";
            this.pay_button.Size = new System.Drawing.Size(84, 26);
            this.pay_button.TabIndex = 10;
            this.pay_button.Text = "繳交費用";
            this.pay_button.UseVisualStyleBackColor = true;
            this.pay_button.Click += new System.EventHandler(this.pay_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 379);
            this.Controls.Add(this.pay_button);
            this.Controls.Add(this.cost_display);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.regulation_display);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我是停車場";
            this.panel1.ResumeLayout(false);
            this.outDisply.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtpTime_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTime_end;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.RichTextBox regulation_display;
        private System.Windows.Forms.RichTextBox cost_display;
        private System.Windows.Forms.Button speedUp1;
        private System.Windows.Forms.Button speedUp6;
        private System.Windows.Forms.Button speedUp5;
        private System.Windows.Forms.Button speedUp4;
        private System.Windows.Forms.Button speedUp3;
        private System.Windows.Forms.Button speedUp2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel outDisply;
        private System.Windows.Forms.Button pay_button;
        private System.Windows.Forms.Button restart_button;
    }
}

