namespace ClickForPid
{
    partial class Display
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

        private void InitializeComponent()
        {
            this.pidDisplay = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pidDisplay
            // 
            this.pidDisplay.Location = new System.Drawing.Point(10, 10);
            this.pidDisplay.Name = "pidDisplay";
            this.pidDisplay.Size = new System.Drawing.Size(300, 27);
            this.pidDisplay.TabIndex = 0;
            this.pidDisplay.Text = "Click 'Go' then click on the target window";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(320, 9);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(50, 30);
            this.button.TabIndex = 1;
            this.button.Text = "Go";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 50);
            this.Controls.Add(this.button);
            this.Controls.Add(this.pidDisplay);
            this.Name = "Display";
            this.Text = "PID Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox pidDisplay;
        private Button button;
    }
}