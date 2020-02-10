namespace rail_transport_winform
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.startComboBox = new System.Windows.Forms.ComboBox();
            this.returTticket = new System.Windows.Forms.CheckBox();
            this.concessionTicket = new System.Windows.Forms.CheckBox();
            this.cal_button = new System.Windows.Forms.Button();
            this.ticket_display = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.endComboBox = new System.Windows.Forms.ComboBox();
            this.purchase_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.endComboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.startComboBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 144);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "出發站";
            // 
            // startComboBox
            // 
            this.startComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startComboBox.FormattingEnabled = true;
            this.startComboBox.Location = new System.Drawing.Point(7, 32);
            this.startComboBox.Name = "startComboBox";
            this.startComboBox.Size = new System.Drawing.Size(171, 28);
            this.startComboBox.TabIndex = 4;
            // 
            // returTticket
            // 
            this.returTticket.AutoSize = true;
            this.returTticket.Location = new System.Drawing.Point(7, 3);
            this.returTticket.Name = "returTticket";
            this.returTticket.Size = new System.Drawing.Size(76, 24);
            this.returTticket.TabIndex = 0;
            this.returTticket.Text = "來回票";
            this.returTticket.UseVisualStyleBackColor = true;
            // 
            // concessionTicket
            // 
            this.concessionTicket.AutoSize = true;
            this.concessionTicket.Location = new System.Drawing.Point(99, 3);
            this.concessionTicket.Name = "concessionTicket";
            this.concessionTicket.Size = new System.Drawing.Size(76, 24);
            this.concessionTicket.TabIndex = 3;
            this.concessionTicket.Text = "優惠票";
            this.concessionTicket.UseVisualStyleBackColor = true;
            // 
            // cal_button
            // 
            this.cal_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cal_button.Location = new System.Drawing.Point(12, 202);
            this.cal_button.Name = "cal_button";
            this.cal_button.Size = new System.Drawing.Size(80, 27);
            this.cal_button.TabIndex = 3;
            this.cal_button.Text = "計算";
            this.cal_button.UseVisualStyleBackColor = true;
            this.cal_button.Click += new System.EventHandler(this.cal_button_Click);
            // 
            // ticket_display
            // 
            this.ticket_display.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ticket_display.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_display.Location = new System.Drawing.Point(202, 12);
            this.ticket_display.Name = "ticket_display";
            this.ticket_display.ReadOnly = true;
            this.ticket_display.Size = new System.Drawing.Size(167, 217);
            this.ticket_display.TabIndex = 4;
            this.ticket_display.Text = "";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "抵達站";
            // 
            // endComboBox
            // 
            this.endComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endComboBox.FormattingEnabled = true;
            this.endComboBox.Location = new System.Drawing.Point(7, 96);
            this.endComboBox.Name = "endComboBox";
            this.endComboBox.Size = new System.Drawing.Size(171, 28);
            this.endComboBox.TabIndex = 6;
            // 
            // purchase_button
            // 
            this.purchase_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchase_button.Location = new System.Drawing.Point(115, 202);
            this.purchase_button.Name = "purchase_button";
            this.purchase_button.Size = new System.Drawing.Size(80, 27);
            this.purchase_button.TabIndex = 6;
            this.purchase_button.Text = "購買";
            this.purchase_button.UseVisualStyleBackColor = true;
            this.purchase_button.Click += new System.EventHandler(this.purchase_button_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.concessionTicket);
            this.panel1.Controls.Add(this.returTticket);
            this.panel1.Location = new System.Drawing.Point(13, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 34);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 236);
            this.Controls.Add(this.purchase_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cal_button);
            this.Controls.Add(this.ticket_display);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我是購票機";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox startComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cal_button;
        private System.Windows.Forms.CheckBox concessionTicket;
        private System.Windows.Forms.CheckBox returTticket;
        private System.Windows.Forms.RichTextBox ticket_display;
        private System.Windows.Forms.ComboBox endComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button purchase_button;
        private System.Windows.Forms.Panel panel1;
    }
}

