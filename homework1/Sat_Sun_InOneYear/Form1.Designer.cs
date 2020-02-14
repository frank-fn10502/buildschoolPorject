namespace Sat_Sun_InOneYear
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
            this.label1 = new System.Windows.Forms.Label();
            this.cal_button = new System.Windows.Forms.Button();
            this.yearType_comboBox = new System.Windows.Forms.ComboBox();
            this.display_textBox = new System.Windows.Forms.TextBox();
            this.input_numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.input_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "年份:";
            // 
            // cal_button
            // 
            this.cal_button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cal_button.Location = new System.Drawing.Point(290, 29);
            this.cal_button.Name = "cal_button";
            this.cal_button.Size = new System.Drawing.Size(79, 34);
            this.cal_button.TabIndex = 2;
            this.cal_button.Text = "計算";
            this.cal_button.UseVisualStyleBackColor = true;
            this.cal_button.Click += new System.EventHandler(this.cal_button_Click);
            // 
            // yearType_comboBox
            // 
            this.yearType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearType_comboBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yearType_comboBox.FormattingEnabled = true;
            this.yearType_comboBox.Location = new System.Drawing.Point(66, 29);
            this.yearType_comboBox.Name = "yearType_comboBox";
            this.yearType_comboBox.Size = new System.Drawing.Size(82, 33);
            this.yearType_comboBox.TabIndex = 4;
            this.yearType_comboBox.SelectedIndexChanged += new System.EventHandler(this.yearType_comboBox_SelectedIndexChanged);
            // 
            // display_textBox
            // 
            this.display_textBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.display_textBox.Location = new System.Drawing.Point(12, 69);
            this.display_textBox.Multiline = true;
            this.display_textBox.Name = "display_textBox";
            this.display_textBox.ReadOnly = true;
            this.display_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.display_textBox.Size = new System.Drawing.Size(373, 489);
            this.display_textBox.TabIndex = 5;
            this.display_textBox.Text = "None";
            // 
            // input_numericUpDown
            // 
            this.input_numericUpDown.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.input_numericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.input_numericUpDown.Location = new System.Drawing.Point(164, 28);
            this.input_numericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.input_numericUpDown.Name = "input_numericUpDown";
            this.input_numericUpDown.Size = new System.Drawing.Size(120, 34);
            this.input_numericUpDown.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 561);
            this.Controls.Add(this.input_numericUpDown);
            this.Controls.Add(this.display_textBox);
            this.Controls.Add(this.yearType_comboBox);
            this.Controls.Add(this.cal_button);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "星期計算";
            ((System.ComponentModel.ISupportInitialize)(this.input_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cal_button;
        private System.Windows.Forms.ComboBox yearType_comboBox;
        private System.Windows.Forms.TextBox display_textBox;
        private System.Windows.Forms.NumericUpDown input_numericUpDown;
    }
}

