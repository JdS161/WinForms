namespace CW_05152022
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trBarRed = new System.Windows.Forms.TrackBar();
            this.trBarGreen = new System.Windows.Forms.TrackBar();
            this.trBarBlue = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(34, 122);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(195, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(34, 32);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(195, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // trBarRed
            // 
            this.trBarRed.Location = new System.Drawing.Point(353, 12);
            this.trBarRed.Maximum = 255;
            this.trBarRed.Name = "trBarRed";
            this.trBarRed.Size = new System.Drawing.Size(309, 56);
            this.trBarRed.TabIndex = 0;
            this.trBarRed.Value = 23;
            this.trBarRed.Scroll += new System.EventHandler(this.trBarRed_Scroll);
            // 
            // trBarGreen
            // 
            this.trBarGreen.Location = new System.Drawing.Point(353, 89);
            this.trBarGreen.Maximum = 255;
            this.trBarGreen.Name = "trBarGreen";
            this.trBarGreen.Size = new System.Drawing.Size(309, 56);
            this.trBarGreen.TabIndex = 1;
            this.trBarGreen.Value = 210;
            this.trBarGreen.Scroll += new System.EventHandler(this.trBarGreen_Scroll);
            // 
            // trBarBlue
            // 
            this.trBarBlue.Location = new System.Drawing.Point(353, 165);
            this.trBarBlue.Maximum = 255;
            this.trBarBlue.Name = "trBarBlue";
            this.trBarBlue.Size = new System.Drawing.Size(309, 56);
            this.trBarBlue.TabIndex = 2;
            this.trBarBlue.Value = 120;
            this.trBarBlue.Scroll += new System.EventHandler(this.trBarBlue_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "RED";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "GREEN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "BLUE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 394);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trBarBlue);
            this.Controls.Add(this.trBarGreen);
            this.Controls.Add(this.trBarRed);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trBarRed;
        private System.Windows.Forms.TrackBar trBarGreen;
        private System.Windows.Forms.TrackBar trBarBlue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

