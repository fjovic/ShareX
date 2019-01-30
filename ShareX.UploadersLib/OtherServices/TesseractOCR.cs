using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;
using Yandex.Translator;

namespace ShareX.UploadersLib.OtherServices
{
    
    public class TesseractOCR : IOCREngine
    {
        public string DoOCR(Stream stream, Languages language)
        {
            var img = Image.FromStream(stream) as Bitmap;
            var ocr = new TesseractEngine("./tessdata", language.ToString(), EngineMode.TesseractAndCube);
            var page = ocr.Process(img);

            return page.GetText();
        }
    }
}
