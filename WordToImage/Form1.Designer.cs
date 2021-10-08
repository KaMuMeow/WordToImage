
namespace WordToImage
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
            this.Btn_Done = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Pic_result = new System.Windows.Forms.PictureBox();
            this.Text_Output = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_result)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Done
            // 
            this.Btn_Done.Location = new System.Drawing.Point(12, 114);
            this.Btn_Done.Name = "Btn_Done";
            this.Btn_Done.Size = new System.Drawing.Size(75, 23);
            this.Btn_Done.TabIndex = 0;
            this.Btn_Done.Text = "轉換";
            this.Btn_Done.UseVisualStyleBackColor = true;
            this.Btn_Done.Click += new System.EventHandler(this.Btn_Done_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Pic_result
            // 
            this.Pic_result.Location = new System.Drawing.Point(12, 162);
            this.Pic_result.Name = "Pic_result";
            this.Pic_result.Size = new System.Drawing.Size(164, 137);
            this.Pic_result.TabIndex = 2;
            this.Pic_result.TabStop = false;
            // 
            // Text_Output
            // 
            this.Text_Output.Location = new System.Drawing.Point(221, 12);
            this.Text_Output.Name = "Text_Output";
            this.Text_Output.Size = new System.Drawing.Size(710, 500);
            this.Text_Output.TabIndex = 3;
            this.Text_Output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 524);
            this.Controls.Add(this.Text_Output);
            this.Controls.Add(this.Pic_result);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_Done);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Done;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox Pic_result;
        private System.Windows.Forms.RichTextBox Text_Output;
    }
}

