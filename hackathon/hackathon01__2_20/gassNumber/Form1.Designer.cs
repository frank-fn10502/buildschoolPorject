namespace gassNumber
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
            this.answer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.record_display = new System.Windows.Forms.RichTextBox();
            this.check_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.restart_button = new System.Windows.Forms.Button();
            this.sneak_display = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // answer
            // 
            this.answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answer.Location = new System.Drawing.Point(45, 2);
            this.answer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(220, 30);
            this.answer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "答案:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // record_display
            // 
            this.record_display.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.record_display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.record_display.Location = new System.Drawing.Point(6, 39);
            this.record_display.Name = "record_display";
            this.record_display.ReadOnly = true;
            this.record_display.Size = new System.Drawing.Size(353, 262);
            this.record_display.TabIndex = 2;
            this.record_display.Text = "";
            // 
            // check_button
            // 
            this.check_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_button.Location = new System.Drawing.Point(307, 11);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(58, 33);
            this.check_button.TabIndex = 3;
            this.check_button.Text = "偷看";
            this.check_button.UseVisualStyleBackColor = true;
            this.check_button.Click += new System.EventHandler(this.check_button_Click);
            // 
            // start_button
            // 
            this.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_button.Location = new System.Drawing.Point(12, 11);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(98, 33);
            this.start_button.TabIndex = 5;
            this.start_button.Text = "開始遊戲";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // restart_button
            // 
            this.restart_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restart_button.Location = new System.Drawing.Point(116, 11);
            this.restart_button.Name = "restart_button";
            this.restart_button.Size = new System.Drawing.Size(98, 33);
            this.restart_button.TabIndex = 6;
            this.restart_button.Text = "重新開始";
            this.restart_button.UseVisualStyleBackColor = true;
            this.restart_button.Click += new System.EventHandler(this.restart_button_Click);
            // 
            // sneak_display
            // 
            this.sneak_display.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sneak_display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sneak_display.Location = new System.Drawing.Point(277, 2);
            this.sneak_display.Margin = new System.Windows.Forms.Padding(4);
            this.sneak_display.Name = "sneak_display";
            this.sneak_display.ReadOnly = true;
            this.sneak_display.Size = new System.Drawing.Size(82, 30);
            this.sneak_display.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.answer);
            this.panel1.Controls.Add(this.sneak_display);
            this.panel1.Controls.Add(this.record_display);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 307);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 359);
            this.Controls.Add(this.restart_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.check_button);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "猜數字(1A2B)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox record_display;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button restart_button;
        private System.Windows.Forms.TextBox sneak_display;
        private System.Windows.Forms.Panel panel1;
    }
}

