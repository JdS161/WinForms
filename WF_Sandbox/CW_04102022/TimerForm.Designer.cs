namespace CW_04102022
{
    partial class TimerForm
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
            this.numericCounter = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelForTimer = new System.Windows.Forms.Label();
            this.labelCountdown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // numericCounter
            // 
            this.numericCounter.Location = new System.Drawing.Point(164, 32);
            this.numericCounter.Name = "numericCounter";
            this.numericCounter.Size = new System.Drawing.Size(63, 22);
            this.numericCounter.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(31, 129);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(152, 129);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelForTimer
            // 
            this.labelForTimer.AutoSize = true;
            this.labelForTimer.Location = new System.Drawing.Point(12, 34);
            this.labelForTimer.Name = "labelForTimer";
            this.labelForTimer.Size = new System.Drawing.Size(124, 16);
            this.labelForTimer.TabIndex = 3;
            this.labelForTimer.Text = "Number of seconds";
            // 
            // labelCountdown
            // 
            this.labelCountdown.AutoSize = true;
            this.labelCountdown.Location = new System.Drawing.Point(98, 89);
            this.labelCountdown.Name = "labelCountdown";
            this.labelCountdown.Size = new System.Drawing.Size(0, 20);
            this.labelCountdown.TabIndex = 4;
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 164);
            this.Controls.Add(this.labelCountdown);
            this.Controls.Add(this.labelForTimer);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.numericCounter);
            this.Name = "TimerForm";
            this.Text = "Timer";
            ((System.ComponentModel.ISupportInitialize)(this.numericCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericCounter;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelForTimer;
        private System.Windows.Forms.Label labelCountdown;
    }
}