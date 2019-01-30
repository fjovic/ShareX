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

using System;
using System.ComponentModel;

namespace ShareX.HelpersLib
{
    [Flags]
    public enum AfterCaptureTasks // Localized
    {
        [Description("false")]
        None = 0,
        [Description("false")]
        ShowQuickTaskMenu = 1,
        [Description("false")]
        ShowAfterCaptureWindow = 1 << 1,
        [Description("false")]
        AddImageEffects = 1 << 2,
        [Description("false")]
        AnnotateImage = 1 << 3,
        [Description("false")]
        CopyImageToClipboard = 1 << 4,
        [Description("false")]
        SendImageToPrinter = 1 << 5,
        [Description("false")]
        SaveImageToFile = 1 << 6,
        [Description("false")]
        SaveImageToFileWithDialog = 1 << 7,
        [Description("false")]
        SaveThumbnailImageToFile = 1 << 8,
        [Description("false")]
        PerformActions = 1 << 9,
        [Description("false")]
        CopyFileToClipboard = 1 << 10,
        [Description("false")]
        CopyFilePathToClipboard = 1 << 11,
        [Description("false")]
        ShowInExplorer = 1 << 12,
        [Description("false")]
        ScanQRCode = 1 << 13,
        [Description("false")]
        DoOCR = 1 << 14,
        [Description("false")]
        ShowBeforeUploadWindow = 1 << 15,
        [Description("false")]
        UploadImageToHost = 1 << 16,
        [Description("false")]
        DeleteFile = 1 << 17
    }


    public enum EDataType
    {
        Default,
        File,
        Image,
        Text,
        URL
    }

    public enum EClipboardContentType
    {
        Default,
        Image,
        Text,
        Files
    }

    public enum PNGBitDepth // Localized
    {
        Default,
        Automatic,
        Bit32,
        Bit24
    }

    public enum GIFQuality // Localized
    {
        Default,
        Bit8,
        Bit4,
        Grayscale
    }

    public enum EImageFormat
    {
        [Description("png")]
        PNG,
        [Description("jpg")]
        JPEG,
        [Description("gif")]
        GIF,
        [Description("bmp")]
        BMP,
        [Description("tif")]
        TIFF
    }

    public enum HashType
    {
        [Description("CRC-32")]
        CRC32,
        [Description("MD5")]
        MD5,
        [Description("SHA-1")]
        SHA1,
        [Description("SHA-256")]
        SHA256,
        [Description("SHA-384")]
        SHA384,
        [Description("SHA-512")]
        SHA512,
        [Description("RIPEMD-160")]
        RIPEMD160
    }

    public enum BorderType
    {
        Outside,
        Inside
    }

    public enum DownloaderFormStatus
    {
        Waiting,
        DownloadStarted,
        DownloadCompleted,
        InstallStarted
    }

    public enum InstallType
    {
        Default,
        Silent,
        VerySilent,
        Event
    }

    public enum ReleaseChannelType
    {
        [Description("Stable version")]
        Stable,
        [Description("Beta version")]
        Beta,
        [Description("Dev version")]
        Dev
    }

    public enum UpdateStatus
    {
        None,
        UpdateCheckFailed,
        UpdateAvailable,
        UpToDate
    }

    public enum PrintType
    {
        Image,
        Text
    }

    public enum DrawStyle
    {
        Hue,
        Saturation,
        Brightness,
        Red,
        Green,
        Blue
    }

    public enum ColorType
    {
        None, RGBA, HSB, CMYK, Hex, Decimal
    }

    public enum ColorFormat
    {
        RGB, RGBA, ARGB
    }

    public enum ProxyMethod // Localized
    {
        None,
        Manual,
        Automatic
    }

    public enum SlashType
    {
        Prefix,
        Suffix
    }

    public enum ScreenTearingTestMode
    {
        VerticalLines,
        HorizontalLines
    }

    public enum HotkeyStatus
    {
        Registered,
        Failed,
        NotConfigured
    }
}