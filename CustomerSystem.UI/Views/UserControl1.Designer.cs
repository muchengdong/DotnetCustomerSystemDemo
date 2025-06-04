using System.ComponentModel;

namespace CustomerSystem.UI.Views {
    partial class UserControl1 {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridPanel1 = new AntdUI.GridPanel();
            this.panel2 = new AntdUI.Panel();
            this.panel1 = new AntdUI.Panel();
            this.gridPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPanel1
            // 
            this.gridPanel1.Controls.Add(this.panel1);
            this.gridPanel1.Controls.Add(this.panel2);
            this.gridPanel1.Location = new System.Drawing.Point(25, 95);
            this.gridPanel1.Name = "gridPanel1";
            this.gridPanel1.Size = new System.Drawing.Size(412, 453);
            this.gridPanel1.TabIndex = 0;
            this.gridPanel1.Text = "gridPanel1";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 220);
            this.panel2.TabIndex = 1;
            this.panel2.Text = "panel2";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(209, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 220);
            this.panel1.TabIndex = 2;
            this.panel1.Text = "panel1";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(448, 591);
            this.gridPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private AntdUI.Panel panel1;

        private AntdUI.GridPanel gridPanel1;
        private AntdUI.Panel panel2;

        #endregion
    }
}