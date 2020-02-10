namespace braised_dishes_winform
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.menu = new System.Windows.Forms.Panel();
            this.menu_display = new System.Windows.Forms.RichTextBox();
            this.Check_button = new System.Windows.Forms.Button();
            this.check_display = new System.Windows.Forms.RichTextBox();
            this.reset_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "高麗菜";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(228, 11);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(70, 29);
            this.numericUpDown1.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.AutoScroll = true;
            this.menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu.Controls.Add(this.numericUpDown1);
            this.menu.Controls.Add(this.label1);
            this.menu.Location = new System.Drawing.Point(12, 43);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(315, 438);
            this.menu.TabIndex = 2;
            // 
            // menu_display
            // 
            this.menu_display.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menu_display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu_display.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_display.Location = new System.Drawing.Point(333, 12);
            this.menu_display.Name = "menu_display";
            this.menu_display.ReadOnly = true;
            this.menu_display.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.menu_display.Size = new System.Drawing.Size(314, 274);
            this.menu_display.TabIndex = 3;
            this.menu_display.Text = "";
            // 
            // Check_button
            // 
            this.Check_button.Location = new System.Drawing.Point(450, 292);
            this.Check_button.Name = "Check_button";
            this.Check_button.Size = new System.Drawing.Size(80, 29);
            this.Check_button.TabIndex = 4;
            this.Check_button.Text = "結帳";
            this.Check_button.UseVisualStyleBackColor = true;
            this.Check_button.Click += new System.EventHandler(this.Check_button_Click);
            // 
            // check_display
            // 
            this.check_display.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.check_display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.check_display.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_display.Location = new System.Drawing.Point(333, 327);
            this.check_display.Name = "check_display";
            this.check_display.ReadOnly = true;
            this.check_display.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.check_display.Size = new System.Drawing.Size(314, 154);
            this.check_display.TabIndex = 5;
            this.check_display.Text = "";
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(247, 12);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(80, 29);
            this.reset_button.TabIndex = 6;
            this.reset_button.Text = "重選";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 485);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.check_display);
            this.Controls.Add(this.Check_button);
            this.Controls.Add(this.menu_display);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我是滷味攤";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.RichTextBox menu_display;
        private System.Windows.Forms.Button Check_button;
        private System.Windows.Forms.RichTextBox check_display;
        private System.Windows.Forms.Button reset_button;
    }
}

