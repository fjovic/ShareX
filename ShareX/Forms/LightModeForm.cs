using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ShareX.HelpersLib;

namespace ShareX.Forms
{
    public partial class LightModeForm : Form
    {
        public bool IsMouseDown { get; set; }
        public Point LastLocation { get; set; }
        public Image CapturedImage { get; set; }
        public AfterCaptureTasks SelectedAfterCaptureTask { get; set; } = AfterCaptureTasks.None;

        private Pen BorderDotPenBlack = new Pen(Color.Black, 1);
        private Pen BorderDotPenWhite = new Pen(Color.White, 1);
        private LightModeSettings LightModeSettings { get; set; }
        private Size ButtonSize { get; set; } = new Size(30, 30);
        private Dictionary<Button, string> ButtonToolTips { get; set; }

        public LightModeForm(Rectangle rect, Image img, LightModeSettings ligthModeSettings)
        {
            InitializeComponent();
            this.ButtonToolTips = new Dictionary<Button, string>();
            this.BackColor = Color.Lime;
            this.TransparencyKey = Color.Lime;
            CapturedImage = img;
            LightModeSettings = ligthModeSettings;
            var numberOfButtons = ligthModeSettings.NumberOfAvailableFunctions;
            this.flowLayoutPanel.MaximumSize = new Size(ButtonSize.Width * numberOfButtons + 2, ButtonSize.Height);
            this.flowLayoutPanel.MinimumSize = new Size(ButtonSize.Width * numberOfButtons + 2, ButtonSize.Height);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            rect.Height += this.flowLayoutPanel.Height;
            if (rect.Width < this.flowLayoutPanel.MinimumSize.Width)
            {
                rect.X -= (this.flowLayoutPanel.MinimumSize.Width - rect.Width);
                rect.Width = this.flowLayoutPanel.MinimumSize.Width;
                this.panelScreenShot.Dock = DockStyle.Right;
            }

            this.DesktopBounds = rect;
            this.MaximumSize = new Size(rect.Width, rect.Height);
            this.MinimumSize = new Size(rect.Width, rect.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            this.panelScreenShot.MaximumSize = new Size(img.Width, img.Height);
            this.panelScreenShot.Width = img.Width;
            this.panelScreenShot.Height = img.Height;
            this.panelScreenShot.BackgroundImage = img;
            BorderDotPenWhite.DashPattern = new float[] { 5, 5 };
            this.flowLayoutPanel.Top = this.panelScreenShot.Bottom;
            this.flowLayoutPanel.Left = this.panelScreenShot.Right - this.flowLayoutPanel.Width;

            AddButtons();
        }

        private void AddButtons()
        {
            var descriptions = Helpers.GetLocalizedEnumDescriptions<AfterCaptureTasks>();
            var values = Enum.GetValues(typeof(AfterCaptureTasks));
            int i = 0;
            foreach (AfterCaptureTasks value in values)
            {
                if ((LightModeSettings.AfterCaptureTasks & value) != 0)
                {
                    var button = new Button()
                    {
                        Name = "btn" + Enum.GetName(typeof(AfterCaptureTasks), value) + i,
                        Size = ButtonSize,
                        BackColor = Color.White,
                        Margin = new Padding(0, 0, 0, 0),
                        BackgroundImageLayout = ImageLayout.Center,
                        BackgroundImage = TaskHelpers.FindMenuIcon<AfterCaptureTasks>(i),
                        FlatStyle = FlatStyle.Flat,
                        
                    };
                    ButtonToolTips.Add(button, descriptions[i]);
                    button.Click += new EventHandler((object sender, EventArgs e) =>
                    {
                        SelectedAfterCaptureTask = value;
                        DialogResult = DialogResult.OK;
                        this.Close();
                    });
                    button.MouseHover += new EventHandler((object sender, EventArgs e) =>
                    {
                        this.toolTip.Show(ButtonToolTips[button], button);
                    });
                    button.TabStop = false;
                    this.flowLayoutPanel.Controls.Add(button);
                }
                ++i;
            }
        }

        private void panelScreenShot_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            LastLocation = e.Location;
        }

        private void panelScreenShot_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                this.Location = new Point(this.Location.X - LastLocation.X + e.X,
                    this.Location.Y - LastLocation.Y + e.Y);
                this.Update();
            }
        }

        private void panelScreenShot_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
        }

        private void panelScreenShot_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangleProper(BorderDotPenBlack, this.panelScreenShot.DisplayRectangle);
            e.Graphics.DrawRectangleProper(BorderDotPenWhite, this.panelScreenShot.DisplayRectangle);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                DialogResult = DialogResult.OK;
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
