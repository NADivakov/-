namespace Lab_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ColseForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ColseForm
            // 
            this.ColseForm.Location = new System.Drawing.Point(338, 204);
            this.ColseForm.Name = "ColseForm";
            this.ColseForm.Size = new System.Drawing.Size(94, 29);
            this.ColseForm.TabIndex = 0;
            this.ColseForm.Text = "Close form";
            this.ColseForm.UseVisualStyleBackColor = true;
            this.ColseForm.Click += new System.EventHandler(this.ColseForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 453);
            this.Controls.Add(this.ColseForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Trey Research";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ColseForm;
    }
}

