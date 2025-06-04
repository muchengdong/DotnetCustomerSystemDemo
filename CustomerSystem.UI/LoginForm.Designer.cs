namespace CustomerSystem.UI
{
    partial class LoginForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new AntdUI.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.sliderRange1 = new AntdUI.SliderRange();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(673, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 58);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 90);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(663, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 73);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(605, 125);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(170, 21);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // sliderRange1
            // 
            this.sliderRange1.Location = new System.Drawing.Point(194, 145);
            this.sliderRange1.Name = "sliderRange1";
            this.sliderRange1.Size = new System.Drawing.Size(195, 68);
            this.sliderRange1.TabIndex = 5;
            this.sliderRange1.Text = "sliderRange1";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 460);
            this.Controls.Add(this.sliderRange1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private AntdUI.SliderRange sliderRange1;

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;

        private AntdUI.Button button3;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.CheckBox checkBox1;

        #endregion

        private System.Windows.Forms.Button button1;
    }
}