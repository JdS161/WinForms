namespace CW_04172022
{
    partial class HeirForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCloseHeirForm = new System.Windows.Forms.Button();
            this.tbHeirForm = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCloseHeirForm
            // 
            this.btnCloseHeirForm.Location = new System.Drawing.Point(69, 164);
            this.btnCloseHeirForm.Name = "btnCloseHeirForm";
            this.btnCloseHeirForm.Size = new System.Drawing.Size(207, 47);
            this.btnCloseHeirForm.TabIndex = 3;
            this.btnCloseHeirForm.Text = "Close";
            this.btnCloseHeirForm.UseVisualStyleBackColor = true;
            this.btnCloseHeirForm.Click += new System.EventHandler(this.btnCloseHeirForm_Click);
            // 
            // tbHeirForm
            // 
            this.tbHeirForm.Location = new System.Drawing.Point(69, 57);
            this.tbHeirForm.Multiline = true;
            this.tbHeirForm.Name = "tbHeirForm";
            this.tbHeirForm.Size = new System.Drawing.Size(207, 76);
            this.tbHeirForm.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(310, 164);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(209, 47);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // HeirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 230);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCloseHeirForm);
            this.Controls.Add(this.tbHeirForm);
            this.Name = "HeirForm";
            this.Text = "HeirForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseHeirForm;
        private System.Windows.Forms.TextBox tbHeirForm;
        private System.Windows.Forms.Button btnOK;
    }
}