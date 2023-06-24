
namespace Dodgson
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rangeDGV = new System.Windows.Forms.DataGridView();
            this.rangeAddButton = new System.Windows.Forms.Button();
            this.rangeSize = new System.Windows.Forms.NumericUpDown();
            this.GDGV = new System.Windows.Forms.DataGridView();
            this.HDGV = new System.Windows.Forms.DataGridView();
            this.resultDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rangeDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // rangeDGV
            // 
            this.rangeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rangeDGV.Location = new System.Drawing.Point(13, 13);
            this.rangeDGV.Name = "rangeDGV";
            this.rangeDGV.Size = new System.Drawing.Size(453, 208);
            this.rangeDGV.TabIndex = 0;
            // 
            // rangeAddButton
            // 
            this.rangeAddButton.Location = new System.Drawing.Point(12, 255);
            this.rangeAddButton.Name = "rangeAddButton";
            this.rangeAddButton.Size = new System.Drawing.Size(75, 23);
            this.rangeAddButton.TabIndex = 3;
            this.rangeAddButton.Text = "Решить";
            this.rangeAddButton.UseVisualStyleBackColor = true;
            this.rangeAddButton.Click += new System.EventHandler(this.rangeAddButton_Click);
            // 
            // rangeSize
            // 
            this.rangeSize.Location = new System.Drawing.Point(222, 255);
            this.rangeSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rangeSize.Name = "rangeSize";
            this.rangeSize.Size = new System.Drawing.Size(120, 20);
            this.rangeSize.TabIndex = 4;
            this.rangeSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rangeSize.ValueChanged += new System.EventHandler(this.resizeDGV);
            // 
            // GDGV
            // 
            this.GDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDGV.Location = new System.Drawing.Point(510, 13);
            this.GDGV.Name = "GDGV";
            this.GDGV.Size = new System.Drawing.Size(353, 208);
            this.GDGV.TabIndex = 5;
            // 
            // HDGV
            // 
            this.HDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HDGV.Location = new System.Drawing.Point(510, 255);
            this.HDGV.Name = "HDGV";
            this.HDGV.Size = new System.Drawing.Size(353, 102);
            this.HDGV.TabIndex = 6;
            // 
            // resultDGV
            // 
            this.resultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDGV.Location = new System.Drawing.Point(510, 384);
            this.resultDGV.Name = "resultDGV";
            this.resultDGV.Size = new System.Drawing.Size(353, 150);
            this.resultDGV.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 574);
            this.Controls.Add(this.resultDGV);
            this.Controls.Add(this.HDGV);
            this.Controls.Add(this.GDGV);
            this.Controls.Add(this.rangeSize);
            this.Controls.Add(this.rangeAddButton);
            this.Controls.Add(this.rangeDGV);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rangeDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView rangeDGV;
        private System.Windows.Forms.Button rangeAddButton;
        private System.Windows.Forms.NumericUpDown rangeSize;
        private System.Windows.Forms.DataGridView GDGV;
        private System.Windows.Forms.DataGridView HDGV;
        private System.Windows.Forms.DataGridView resultDGV;
    }
}

