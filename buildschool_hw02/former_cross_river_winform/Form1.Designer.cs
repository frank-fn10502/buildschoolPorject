namespace farmer_cross_river_winform
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
            this.side1 = new System.Windows.Forms.ListBox();
            this.side2 = new System.Windows.Forms.ListBox();
            this.cross_button = new System.Windows.Forms.Button();
            this.previous_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reStart_button = new System.Windows.Forms.Button();
            this.historical_record_panel = new System.Windows.Forms.Panel();
            this.step_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // side1
            // 
            this.side1.FormattingEnabled = true;
            this.side1.ItemHeight = 21;
            this.side1.Location = new System.Drawing.Point(12, 71);
            this.side1.Margin = new System.Windows.Forms.Padding(5);
            this.side1.Name = "side1";
            this.side1.Size = new System.Drawing.Size(95, 214);
            this.side1.TabIndex = 0;
            // 
            // side2
            // 
            this.side2.FormattingEnabled = true;
            this.side2.ItemHeight = 21;
            this.side2.Location = new System.Drawing.Point(206, 71);
            this.side2.Margin = new System.Windows.Forms.Padding(5);
            this.side2.Name = "side2";
            this.side2.Size = new System.Drawing.Size(95, 214);
            this.side2.TabIndex = 1;
            // 
            // cross_button
            // 
            this.cross_button.BackColor = System.Drawing.Color.Transparent;
            this.cross_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cross_button.Location = new System.Drawing.Point(119, 178);
            this.cross_button.Name = "cross_button";
            this.cross_button.Size = new System.Drawing.Size(75, 29);
            this.cross_button.TabIndex = 2;
            this.cross_button.Text = "<-->";
            this.cross_button.UseVisualStyleBackColor = false;
            this.cross_button.Click += new System.EventHandler(this.cross_button_Click);
            // 
            // previous_button
            // 
            this.previous_button.BackColor = System.Drawing.Color.Transparent;
            this.previous_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous_button.Location = new System.Drawing.Point(119, 131);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(75, 29);
            this.previous_button.TabIndex = 4;
            this.previous_button.Text = "上一步";
            this.previous_button.UseVisualStyleBackColor = false;
            this.previous_button.Click += new System.EventHandler(this.previous_button_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(307, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "移動紀錄:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "左邊";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(204, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "右邊";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(117, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "河流";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(115, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 214);
            this.label5.TabIndex = 9;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reStart_button
            // 
            this.reStart_button.BackColor = System.Drawing.Color.Transparent;
            this.reStart_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reStart_button.Location = new System.Drawing.Point(611, 39);
            this.reStart_button.Name = "reStart_button";
            this.reStart_button.Size = new System.Drawing.Size(89, 32);
            this.reStart_button.TabIndex = 10;
            this.reStart_button.Text = "重新開始";
            this.reStart_button.UseVisualStyleBackColor = false;
            this.reStart_button.Click += new System.EventHandler(this.reStart_button_Click);
            // 
            // historical_record_panel
            // 
            this.historical_record_panel.AutoScroll = true;
            this.historical_record_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historical_record_panel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historical_record_panel.Location = new System.Drawing.Point(309, 71);
            this.historical_record_panel.Name = "historical_record_panel";
            this.historical_record_panel.Size = new System.Drawing.Size(391, 214);
            this.historical_record_panel.TabIndex = 11;
            // 
            // step_title
            // 
            this.step_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.step_title.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.step_title.Location = new System.Drawing.Point(16, 9);
            this.step_title.Name = "step_title";
            this.step_title.Size = new System.Drawing.Size(684, 29);
            this.step_title.TabIndex = 12;
            this.step_title.Text = "第00步(紀錄)";
            this.step_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 297);
            this.Controls.Add(this.step_title);
            this.Controls.Add(this.historical_record_panel);
            this.Controls.Add(this.reStart_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previous_button);
            this.Controls.Add(this.cross_button);
            this.Controls.Add(this.side2);
            this.Controls.Add(this.side1);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "農夫過河";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox side1;
        private System.Windows.Forms.ListBox side2;
        private System.Windows.Forms.Button cross_button;
        private System.Windows.Forms.Button previous_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button reStart_button;
        private System.Windows.Forms.Panel historical_record_panel;
        private System.Windows.Forms.Label step_title;
        //private System.Windows.Forms.Label preView_label;
    }
}

