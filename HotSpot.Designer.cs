namespace HotSpot
{
    partial class HotSpot
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
            this.ssid = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ssid
            // 
            this.ssid.Location = new System.Drawing.Point(50, 14);
            this.ssid.Name = "ssid";
            this.ssid.Size = new System.Drawing.Size(257, 22);
            this.ssid.TabIndex = 0;
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(50, 43);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(257, 22);
            this.key.TabIndex = 1;
            this.key.UseSystemPasswordChar = true;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(50, 71);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(257, 39);
            this.button.TabIndex = 2;
            this.button.Text = "Start";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(13, 160);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(337, 122);
            this.textBox1.TabIndex = 4;
            // 
            // HotSpot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 294);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.key);
            this.Controls.Add(this.ssid);
            this.Name = "HotSpot";
            this.Text = "HotSpot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ssid;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

