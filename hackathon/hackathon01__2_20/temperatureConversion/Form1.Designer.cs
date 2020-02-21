namespace temperatureConversion
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
            this.t1 = new System.Windows.Forms.RadioButton();
            this.t2 = new System.Windows.Forms.RadioButton();
            this.random_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear_button = new System.Windows.Forms.Button();
            this.convert_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.AutoSize = true;
            this.t1.Location = new System.Drawing.Point(164, 19);
            this.t1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(73, 29);
            this.t1.TabIndex = 0;
            this.t1.TabStop = true;
            this.t1.Text = "華氏";
            this.t1.UseVisualStyleBackColor = true;
            // 
            // t2
            // 
            this.t2.AutoSize = true;
            this.t2.Location = new System.Drawing.Point(245, 19);
            this.t2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(73, 29);
            this.t2.TabIndex = 1;
            this.t2.TabStop = true;
            this.t2.Text = "攝氏";
            this.t2.UseVisualStyleBackColor = true;
            // 
            // random_button
            // 
            this.random_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.random_button.Location = new System.Drawing.Point(282, 116);
            this.random_button.Name = "random_button";
            this.random_button.Size = new System.Drawing.Size(64, 34);
            this.random_button.TabIndex = 3;
            this.random_button.Text = "亂數";
            this.random_button.UseVisualStyleBackColor = true;
            this.random_button.Click += new System.EventHandler(this.random_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 34);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 179);
            this.panel1.TabIndex = 6;
            // 
            // clear_button
            // 
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button.Location = new System.Drawing.Point(142, 116);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(64, 34);
            this.clear_button.TabIndex = 7;
            this.clear_button.Text = "清除";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // convert_button
            // 
            this.convert_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convert_button.Location = new System.Drawing.Point(212, 116);
            this.convert_button.Name = "convert_button";
            this.convert_button.Size = new System.Drawing.Size(64, 34);
            this.convert_button.TabIndex = 8;
            this.convert_button.Text = "轉換";
            this.convert_button.UseVisualStyleBackColor = true;
            this.convert_button.Click += new System.EventHandler(this.convert_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 202);
            this.Controls.Add(this.convert_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.random_button);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "溫度轉換";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton t1;
        private System.Windows.Forms.RadioButton t2;
        private System.Windows.Forms.Button random_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button convert_button;
    }
}

