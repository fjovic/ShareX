namespace ShareX.UploadersLib
{
    partial class OCRForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OCRForm));
            this.cbOCRLanguages = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.txtOCRResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.llAttribution = new System.Windows.Forms.LinkLabel();
            this.btnStartOCR = new System.Windows.Forms.Button();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.llGoogleTranslate = new System.Windows.Forms.LinkLabel();
            this.txtTranslationResult = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radTesseract = new System.Windows.Forms.RadioButton();
            this.radOCRSpace = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnStartTranslation = new System.Windows.Forms.Button();
            this.cbTranslationLanguages = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbOCRLanguages
            // 
            this.cbOCRLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOCRLanguages.FormattingEnabled = true;
            resources.ApplyResources(this.cbOCRLanguages, "cbOCRLanguages");
            this.cbOCRLanguages.Name = "cbOCRLanguages";
            this.cbOCRLanguages.SelectedIndexChanged += new System.EventHandler(this.cbOCRLanguages_SelectedIndexChanged);
            // 
            // lblLanguage
            // 
            resources.ApplyResources(this.lblLanguage, "lblLanguage");
            this.lblLanguage.Name = "lblLanguage";
            // 
            // txtOCRResult
            // 
            resources.ApplyResources(this.txtOCRResult, "txtOCRResult");
            this.txtOCRResult.Name = "txtOCRResult";
            // 
            // lblResult
            // 
            resources.ApplyResources(this.lblResult, "lblResult");
            this.lblResult.Name = "lblResult";
            // 
            // llAttribution
            // 
            resources.ApplyResources(this.llAttribution, "llAttribution");
            this.llAttribution.Name = "llAttribution";
            this.llAttribution.TabStop = true;
            this.llAttribution.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llOCRSpaceAttribution_LinkClicked);
            // 
            // btnStartOCR
            // 
            resources.ApplyResources(this.btnStartOCR, "btnStartOCR");
            this.btnStartOCR.Name = "btnStartOCR";
            this.btnStartOCR.UseVisualStyleBackColor = true;
            this.btnStartOCR.Click += new System.EventHandler(this.btnStartOCR_Click);
            // 
            // pbProgress
            // 
            resources.ApplyResources(this.pbProgress, "pbProgress");
            this.pbProgress.MarqueeAnimationSpeed = 50;
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // llGoogleTranslate
            // 
            resources.ApplyResources(this.llGoogleTranslate, "llGoogleTranslate");
            this.llGoogleTranslate.Name = "llGoogleTranslate";
            this.llGoogleTranslate.TabStop = true;
            this.llGoogleTranslate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGoogleTranslate_LinkClicked);
            // 
            // txtTranslationResult
            // 
            resources.ApplyResources(this.txtTranslationResult, "txtTranslationResult");
            this.txtTranslationResult.Name = "txtTranslationResult";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtOCRResult);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtTranslationResult);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radTesseract);
            this.groupBox1.Controls.Add(this.radOCRSpace);
            this.groupBox1.Controls.Add(this.llAttribution);
            this.groupBox1.Controls.Add(this.linkLabel1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // radTesseract
            // 
            resources.ApplyResources(this.radTesseract, "radTesseract");
            this.radTesseract.Name = "radTesseract";
            this.radTesseract.UseVisualStyleBackColor = true;
            // 
            // radOCRSpace
            // 
            resources.ApplyResources(this.radOCRSpace, "radOCRSpace");
            this.radOCRSpace.Checked = true;
            this.radOCRSpace.Name = "radOCRSpace";
            this.radOCRSpace.TabStop = true;
            this.radOCRSpace.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llTessaractOCRAttribution_LinkClicked);
            // 
            // btnStartTranslation
            // 
            resources.ApplyResources(this.btnStartTranslation, "btnStartTranslation");
            this.btnStartTranslation.Name = "btnStartTranslation";
            this.btnStartTranslation.UseVisualStyleBackColor = true;
            this.btnStartTranslation.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // cbTranslationLanguages
            // 
            this.cbTranslationLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTranslationLanguages.FormattingEnabled = true;
            resources.ApplyResources(this.cbTranslationLanguages, "cbTranslationLanguages");
            this.cbTranslationLanguages.Name = "cbTranslationLanguages";
            this.cbTranslationLanguages.SelectedIndexChanged += new System.EventHandler(this.cbTranslationLanguages_SelectedIndexChanged);
            // 
            // OCRForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbTranslationLanguages);
            this.Controls.Add(this.btnStartTranslation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.llGoogleTranslate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cbOCRLanguages);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.btnStartOCR);
            this.Name = "OCRForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Shown += new System.EventHandler(this.OCRSpaceResultForm_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOCRLanguages;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.TextBox txtOCRResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.LinkLabel llAttribution;
        private System.Windows.Forms.Button btnStartOCR;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.LinkLabel llGoogleTranslate;
        private System.Windows.Forms.TextBox txtTranslationResult;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radTesseract;
        private System.Windows.Forms.RadioButton radOCRSpace;
        private System.Windows.Forms.Button btnStartTranslation;
        private System.Windows.Forms.ComboBox cbTranslationLanguages;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}