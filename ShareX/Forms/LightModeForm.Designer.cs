namespace ShareX.Forms
{
    partial class LightModeForm
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
            this.components = new System.ComponentModel.Container();
            this.panelScreenShot = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // panelScreenShot
            // 
            this.panelScreenShot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelScreenShot.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelScreenShot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelScreenShot.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelScreenShot.Location = new System.Drawing.Point(0, 0);
            this.panelScreenShot.Margin = new System.Windows.Forms.Padding(0);
            this.panelScreenShot.Name = "panelScreenShot";
            this.panelScreenShot.Size = new System.Drawing.Size(796, 336);
            this.panelScreenShot.TabIndex = 0;
            this.panelScreenShot.Paint += new System.Windows.Forms.PaintEventHandler(this.panelScreenShot_Paint);
            this.panelScreenShot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelScreenShot_MouseDown);
            this.panelScreenShot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelScreenShot_MouseMove);
            this.panelScreenShot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelScreenShot_MouseUp);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 339);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // LightModeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(794, 383);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panelScreenShot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LightModeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelScreenShot;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ToolTip toolTip;
    }
}