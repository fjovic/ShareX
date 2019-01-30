#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright (c) 2007-2018 ShareX Team

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using ShareX.HelpersLib;
using ShareX.UploadersLib.OtherServices;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShareX.UploadersLib
{
    public partial class OCRForm : Form
    {
        public Languages OCRLanguage { get; set; }
        public Languages2 TranslationLanguage { get; set; }
        public string OCRResult { get; private set; }
        public string TranslationResult { get; private set; }

        private Stream data;
        private string filename;
        private IOCREngine ocrEngine;
        private bool translationSuccess;

        public OCRForm()
        {
            InitializeComponent();
            Icon = ShareXResources.Icon;

            cbOCRLanguages.Items.AddRange(Helpers.GetEnumDescriptions<Languages>());
            cbOCRLanguages.SelectedIndex = cbOCRLanguages.FindStringExact(Languages.eng.GetDescription());
            cbOCRLanguages.Refresh();
            OCRLanguage = Languages.eng;

            cbTranslationLanguages.Items.AddRange(Helpers.GetEnumDescriptions<Languages2>());
            cbTranslationLanguages.SelectedIndex = cbTranslationLanguages.FindStringExact(Languages2.sr.GetDescription());
            cbOCRLanguages.Refresh();
            TranslationLanguage = Languages2.sr;
            txtOCRResult.SupportSelectAll();
        }

        public OCRForm(Stream data, string filename) : this()
        {
            this.data = data;
            this.filename = filename;
        }

        private async void OCRSpaceResultForm_Shown(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void UpdateControls(bool updateTranslationOnly = false)
        {
            if (!updateTranslationOnly && !string.IsNullOrEmpty(OCRResult))
            {
                txtOCRResult.Text = OCRResult;
            }
            if (!string.IsNullOrEmpty(TranslationResult))
            {
                txtTranslationResult.Text = TranslationResult;
                if (!translationSuccess)
                {
                    txtTranslationResult.ForeColor = Color.Red;
                }
                else
                {
                    txtTranslationResult.ForeColor = Color.Black;
                }
            }

            btnStartOCR.Visible = data != null && data.Length > 0 && !string.IsNullOrEmpty(filename);
        }

        private async Task StartOCR(Stream stream, string filename)
        {
            if (stream != null && stream.Length > 0 && !string.IsNullOrEmpty(filename))
            {
                cbOCRLanguages.Enabled = btnStartOCR.Enabled = txtOCRResult.Enabled = false;
                cbTranslationLanguages.Enabled = btnStartTranslation.Enabled = txtTranslationResult.Enabled = false;
                pbProgress.Visible = true;

                await Task.Run(() =>
                {
                    try
                    {
                        ocrEngine = radOCRSpace.Checked ? (IOCREngine) new OCRSpace(filename, false) : new TesseractOCR();
                        OCRResult = ocrEngine.DoOCR(stream, OCRLanguage);
                    }
                    catch (Exception e)
                    {
                        DebugHelper.WriteException(e);
                    }
                });

                if (!IsDisposed)
                {
                    UpdateControls();
                    cbOCRLanguages.Enabled = btnStartOCR.Enabled = txtOCRResult.Enabled = true;
                    cbTranslationLanguages.Enabled = btnStartTranslation.Enabled = txtTranslationResult.Enabled = true;
                    pbProgress.Visible = false;
                    txtOCRResult.Focus();
                    llGoogleTranslate.Enabled = true;
                }
            }
        }

        private async Task StartTranslation()
        {
            if (!string.IsNullOrEmpty(txtOCRResult.Text))
            {
                await Task.Run(() =>
                {
                    try
                    {
                        var translator = new YandexTranslator();
                        TranslationResult = translator.Translate(txtOCRResult.Text, HelpersLib.EnumExtensions.GetValueFromDescription<Languages2>(OCRLanguage.GetDescription()), TranslationLanguage, out translationSuccess);
                        if (!translationSuccess)
                        {
                            TranslationResult = String.Format("ERROR: Translation between {0} and {1} is not supported.", OCRLanguage.GetDescription(), TranslationLanguage.GetDescription());
                        }
                    }
                    catch (Exception e)
                    {
                        DebugHelper.WriteException(e);
                    }
                });

                if (!IsDisposed)
                {
                    UpdateControls(true);
                    cbOCRLanguages.Enabled = btnStartOCR.Enabled = txtOCRResult.Enabled = true;
                    cbTranslationLanguages.Enabled = btnStartTranslation.Enabled = txtTranslationResult.Enabled = true;
                    pbProgress.Visible = false;
                    txtTranslationResult.Focus();
                    llGoogleTranslate.Enabled = true;
                }
            }
        }

        private void cbOCRLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            OCRLanguage = (Languages)cbOCRLanguages.SelectedIndex;
        }

        private void cbTranslationLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            TranslationLanguage = (Languages2)cbTranslationLanguages.SelectedIndex;
        }

        private async void btnStartOCR_Click(object sender, EventArgs e)
        {
            await StartOCR(data, filename);
        }

        private void llOCRSpaceAttribution_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            URLHelpers.OpenURL("https://ocr.space");
        }

        private void llGoogleTranslate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            URLHelpers.OpenURL("https://translate.google.com/#auto/en/" + Uri.EscapeDataString(txtOCRResult.Text));
            Close();
        }

        private void llTessaractOCRAttribution_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            URLHelpers.OpenURL("https://opensource.google.com/projects/tesseract");
        }

        private async void btnTranslate_Click(object sender, EventArgs e)
        {
            await StartTranslation();
        }
    }
}