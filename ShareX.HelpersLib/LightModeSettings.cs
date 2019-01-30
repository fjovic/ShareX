using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace ShareX.HelpersLib
{
    public class LightModeSettings
    {
        [Category("Light Mode"), DefaultValue(false), Description("Make ShowQuickTaskMenu task available in light mode.")]
        public bool ShowQuickTaskMenu { get; set; }
        [Category("Light Mode"), DefaultValue(false), Description("Make ShowAfterCaptureWindow task available in light mode.")]
        public bool ShowAfterCaptureWindow { get; set; }
        [Category("Light Mode"), DefaultValue(false), Description("Make AddImageEffects task available in light mode.")]
        public bool AddImageEffects { get; set; }
        [Category("Light Mode"), DefaultValue(false), Description("Make AnnotateImage task available in light mode.")]
        public bool AnnotateImage { get; set; }
        [Category("Light Mode"), DefaultValue(false), Description("Make CopyImageToClipboard task available in light mode.")]
        public bool CopyImageToClipboard { get; set; }
        [Category("Light Mode"), DefaultValue(false), Description("Make SendImageToPrinter task available in light mode.")]
        public bool SendImageToPrinter { get; set; }
        [Category("Light Mode"), DefaultValue(false), Description("Make SaveImageToFile task available in light mode.")]
        public bool SaveImageToFile { get; set; }
        [Category("Light Mode"), DefaultValue(false), Description("Make SaveImageToFileWithDialog task available in light mode.")]
        public bool SaveImageToFileWithDialog { get; set; }
        [Category("Light Mode"), DefaultValue(false), Description("Make SaveThumbnailImageToFile task available in light mode.")]
        public bool SaveThumbnailImageToFile { get; set; }
        [Category("Light Mode"), DefaultValue(false), Description("Make PerformActions task available in light mode.")]
        public bool PerformActions { get; set; }
        [Category("Light Mode"), DefaultValue(false), Description("Make CopyFileToClipboard task available in light mode.")]
        public bool CopyFileToClipboard { get; set; }
        [Category("Light Mode"), DefaultValue(false), Description("Make CopyFilePathToClipboard task available in light mode.")]
        public bool CopyFilePathToClipboard { get; set; }
        [Category("Light Mode"), DefaultValue(false), Description("Make ShowInExplorer task available in light mode.")]
        public bool ShowInExplorer { get; set; }
        [Category("Light Mode"), DefaultValue(false), Description("Make ScanQRCode task available in light mode.")]
        public bool ScanQRCode { get; set; }
        [Category("Light Mode"), DefaultValue(false), Description("Make DoOCR task available in light mode.")]
        public bool DoOCR { get; set; }
        [Category("Light Mode"), DefaultValue(false), Description("Make ShowBeforeUploadWindow task available in light mode.")]
        public bool ShowBeforeUploadWindow { get; set; }
        [Category("Light Mode"), DefaultValue(false), Description("Make UploadImageToHost task available in light mode.")]
        public bool UploadImageToHost { get; set; }
        [Category("Light Mode"), DefaultValue(false), Description("Make DeleteFile task available in light mode.")]
        public bool DeleteFile { get; set; }
        
        [JsonIgnore]
        public AfterCaptureTasks AfterCaptureTasks
        {
            get
            {
                AfterCaptureTasks afterCaptureTasks = AfterCaptureTasks.None;
                foreach (var propertyInfo in this.GetType().GetProperties())
                {
                    if (propertyInfo.Name != "AfterCaptureTasks"
                        && propertyInfo.Name != "NumberOfAvailableFunctions"
                        && (bool)propertyInfo.GetValue(this))
                    {
                        AfterCaptureTasks availableTask;
                        if (Enum.TryParse(propertyInfo.Name, out availableTask))
                        {
                            afterCaptureTasks = afterCaptureTasks | availableTask;
                        }
                        else
                        {
                            throw new ArgumentException("String not an enum member.");
                        }
                    }
                }

                return afterCaptureTasks;
            }
        }

        [JsonIgnore]
        public int NumberOfAvailableFunctions
        {
            get
            {
                var result = 0;
                foreach (var propertyInfo in this.GetType().GetProperties())
                {
                    if (propertyInfo.Name != "AfterCaptureTasks"
                        && propertyInfo.Name != "NumberOfAvailableFunctions"
                        && (bool)propertyInfo.GetValue(this))
                    {
                        AfterCaptureTasks availableTask;
                        if (Enum.TryParse(propertyInfo.Name, out availableTask))
                        {
                            ++result;
                        }
                        else
                        {
                            throw new ArgumentException("String not an enum member.");
                        }
                    }
                }

                return result;
            }
        }

        public override string ToString()
        {
            return "";
        }
    }
}
