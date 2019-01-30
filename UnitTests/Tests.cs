using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShareX;
using ShareX.HelpersLib;

namespace UnitTests
{
    [TestClass]
    public class Tests
    {
        
        [TestMethod]
        public void ReadConfigTest()
        {
            LightModeSettings lightShotConfig = new LightModeSettings()
            {
                CopyImageToClipboard = true,
                DoOCR = true,
                SaveImageToFile = false,
                SendImageToPrinter = false
            };

            var afterCaptureTasks = AfterCaptureTasks.None;
            foreach (var fieldInfo in lightShotConfig.GetType().GetFields())
            {
                if ((bool)fieldInfo.GetValue(lightShotConfig))
                {
                    AfterCaptureTasks availableTask;
                    if (Enum.TryParse(fieldInfo.Name, out availableTask))
                    {
                        afterCaptureTasks = afterCaptureTasks | availableTask;
                    }
                    else { /* error: the string was not an enum member */ }

                }
            }
        }

        [TestMethod]
        public void CaptureRegionTest()
        {
            ShareX.SettingManager.LoadAllSettings();
            new CaptureRegion().Capture(true);
//            new CaptureRegion(RegionCaptureType.Light).Capture(true);
        }
    }
}
