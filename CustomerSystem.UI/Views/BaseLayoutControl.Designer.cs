using System.ComponentModel;

namespace CustomerSystem.UI.Views {
    partial class BaseLayoutControl {
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
            this.gridPanel2 = new AntdUI.GridPanel();
            this.pnlFooter = new AntdUI.Panel();
            this.pnlContent = new AntdUI.Panel();
            this.pnlToolBar = new AntdUI.Panel();
            this.pnlHeader = new AntdUI.Panel();
            this.gridPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gridPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPanel1
            // 
            this.gridPanel1.Controls.Add(this.panel2);
            this.gridPanel1.Controls.Add(this.pnlHeader);
            this.gridPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel1.Gap = 1;
            this.gridPanel1.Location = new System.Drawing.Point(0, 0);
            this.gridPanel1.Name = "gridPanel1";
            this.gridPanel1.Size = new System.Drawing.Size(832, 601);
            this.gridPanel1.Span = "100%;100%;-10% 90%;";
            this.gridPanel1.TabIndex = 0;
            this.gridPanel1.Text = "gridPanel1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 61);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 599);
            this.panel2.TabIndex = 1;
            this.panel2.Text = "panel2";
            // 
            // gridPanel2
            // 
            this.gridPanel2.Controls.Add(this.pnlFooter);
            this.gridPanel2.Controls.Add(this.pnlContent);
            this.gridPanel2.Controls.Add(this.pnlToolBar);
            this.gridPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel2.Location = new System.Drawing.Point(0, 0);
            this.gridPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.gridPanel2.Name = "gridPanel2";
            this.gridPanel2.Size = new System.Drawing.Size(830, 599);
            this.gridPanel2.Span = "100%;100%;100%;-8% 74% 8%;";
            this.gridPanel2.TabIndex = 0;
            this.gridPanel2.Text = "gridPanel2";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(3, 494);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(824, 593);
            this.pnlFooter.TabIndex = 2;
            this.pnlFooter.Text = "panel5";
            // 
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(3, 51);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(824, 437);
            this.pnlContent.TabIndex = 1;
            this.pnlContent.Text = "panel4";
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Location = new System.Drawing.Point(3, 3);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(824, 42);
            this.pnlToolBar.TabIndex = 0;
            this.pnlToolBar.Text = "panel3";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Location = new System.Drawing.Point(1, 1);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(830, 58);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Text = "panel1";
            // 
            // BaseLayoutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPanel1);
            this.Name = "BaseLayoutControl";
            this.Size = new System.Drawing.Size(832, 601);
            this.gridPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gridPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private AntdUI.Panel pnlToolBar;
        private AntdUI.Panel pnlContent;
        private AntdUI.Panel pnlFooter;

        private AntdUI.GridPanel gridPanel2;

        private AntdUI.Panel pnlHeader;
        private AntdUI.Panel panel2;

        private AntdUI.GridPanel gridPanel1;

        #endregion
    }
}