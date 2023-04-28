// System.Windows.Media.Imaging "imitation"

using System;
using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
using System.Windows.Input;

namespace WPR.WindowsCompability
{
    // projection: System.Windows.Media.Imaging
    public class WriteableBitmap //RnD : static
    {
        //static WriteableBitmap writeableBitmap;

        //static 
        WriteableBitmap(int ActualWidth, int ActualHeight)
        {
            /*
            writeableBitmap = new WriteableBitmap(
                (int)ActualWidth,
                (int)ActualHeight,
                96,
                96,
                default,//PixelFormats.Bgr32,
                null);
            */
            return;
        }

        //RnD
        //public static byte[] Protect(byte[] byteArrayOfOriginalData, byte[] additionalEntropyOrSalt)
        //{       
        //    byte[] result = System.Security.Cryptography
        //        .ProtectedData.Protect(byteArrayOfOriginalData, 
        //        additionalEntropyOrSalt, 
        //        DataProtectionScope.CurrentUser);
        //    return result;
        //}

       
    }
}
