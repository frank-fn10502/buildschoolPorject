namespace performance__winform
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
            this.salesmanGridView = new System.Windows.Forms.DataGridView();
            this.merchandiseGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchandiseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // salesmanGridView
            // 
            this.salesmanGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesmanGridView.Location = new System.Drawing.Point(13, 14);
            this.salesmanGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salesmanGridView.Name = "salesmanGridView";
            this.salesmanGridView.RowHeadersWidth = 51;
            this.salesmanGridView.RowTemplate.Height = 27;
            this.salesmanGridView.Size = new System.Drawing.Size(480, 250);
            this.salesmanGridView.TabIndex = 0;
            // 
            // merchandiseGridView
            // 
            this.merchandiseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.merchandiseGridView.Location = new System.Drawing.Point(13, 283);
            this.merchandiseGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.merchandiseGridView.Name = "merchandiseGridView";
            this.merchandiseGridView.RowHeadersWidth = 51;
            this.merchandiseGridView.RowTemplate.Height = 27;
            this.merchandiseGridView.Size = new System.Drawing.Size(480, 164);
            this.merchandiseGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(517, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 43);
            this.label1.TabIndex = 2;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1.Location = new System.Drawing.Point(500, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(543, 433);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 456);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.merchandiseGridView);
            this.Controls.Add(this.salesmanGridView);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "業績表";
            ((System.ComponentModel.ISupportInitialize)(this.salesmanGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchandiseGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView salesmanGridView;
        private System.Windows.Forms.DataGridView merchandiseGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

