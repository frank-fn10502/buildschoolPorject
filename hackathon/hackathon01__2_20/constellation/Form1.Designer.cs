namespace constellation
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
            this.constellation = new System.Windows.Forms.DateTimePicker();
            this.constellation_display = new System.Windows.Forms.RichTextBox();
            this.cal_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "請選擇生日: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // constellation
            // 
            this.constellation.Location = new System.Drawing.Point(120, 9);
            this.constellation.Name = "constellation";
            this.constellation.Size = new System.Drawing.Size(177, 30);
            this.constellation.TabIndex = 1;
            // 
            // constellation_display
            // 
            this.constellation_display.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.constellation_display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.constellation_display.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.constellation_display.Location = new System.Drawing.Point(17, 45);
            this.constellation_display.Name = "constellation_display";
            this.constellation_display.ReadOnly = true;
            this.constellation_display.Size = new System.Drawing.Size(428, 264);
            this.constellation_display.TabIndex = 2;
            this.constellation_display.Text = "";
            // 
            // cal_button
            // 
            this.cal_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cal_button.Location = new System.Drawing.Point(376, 9);
            this.cal_button.Name = "cal_button";
            this.cal_button.Size = new System.Drawing.Size(69, 30);
            this.cal_button.TabIndex = 3;
            this.cal_button.Text = "確定";
            this.cal_button.UseVisualStyleBackColor = true;
            this.cal_button.Click += new System.EventHandler(this.cal_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 321);
            this.Controls.Add(this.cal_button);
            this.Controls.Add(this.constellation_display);
            this.Controls.Add(this.constellation);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生命靈數";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker constellation;
        private System.Windows.Forms.RichTextBox constellation_display;
        private System.Windows.Forms.Button cal_button;
    }
}

