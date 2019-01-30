using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShareX.Forms
{
    public partial class LightModeInitialForm : Form
    {
        public LightModeInitialForm()
        {
            InitializeComponent();
            AddHotkeyLabels();
            btnOK.Top = tableLayoutPanel.Bottom;
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddHotkeyLabels()
        {
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));

            tableLayoutPanel.Controls.Add(new Label() { Text = "Hotkey", Font = new Font(Label.DefaultFont, FontStyle.Bold) }, 0, 0);
            tableLayoutPanel.Controls.Add(new Label() { Text = "Description", Font = new Font(Label.DefaultFont, FontStyle.Bold) }, 1, 0);
            tableLayoutPanel.Controls.Add(new Label() { Text = "Job", Font = new Font(Label.DefaultFont, FontStyle.Bold) }, 2, 0);
            
            foreach (var hotkey in Program.HotkeyManager.Hotkeys)
            {
                AddRowToPanel(tableLayoutPanel, new string[] { hotkey.HotkeyInfo.ToString(), hotkey.TaskSettings.ToString(), hotkey.TaskSettings.Job.ToString() });
            }
        }

        private void AddRowToPanel(TableLayoutPanel panel, string[] rowElements)
        {
            if (panel.ColumnCount != rowElements.Length)
                throw new Exception("Elements number doesn't match!");
            //get a reference to the previous existent row
            RowStyle temp = panel.RowStyles[panel.RowCount - 1];
            //increase panel rows count by one
            panel.RowCount++;
            //add a new RowStyle as a copy of the previous one
            panel.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
            //add the control
            for (int i = 0; i < rowElements.Length; i++)
            {
                var label = new Label();
                label.AutoSize = true;
                label.Text = rowElements[i];
                panel.Controls.Add(label, i, panel.RowCount - 1);
            }
        }
    }
}
