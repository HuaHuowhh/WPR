// System.Windows.Media.Imaging "imitation"

using System;
using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
using System.Windows.Input;
using System.IO;

namespace WPR.WindowsCompability
{
    // projection: System.Windows.Media.Imaging
    public static class BitmapSource //RnD : static
    {
        static BitmapSource()
        {
        }

        //static 
        //BitmapSource(int ActualWidth, int ActualHeight)
        //{
        /*
        writeableBitmap = new WriteableBitmap(
            (int)ActualWidth,
            (int)ActualHeight,
            96,
            96,
            default,//PixelFormats.Bgr32,
            null);
        */
        //    return;
        //}

        //RnD
        public static void SetSource(System.IO.Stream stream)
        {       
            //TODO
            return;
        }

       
    }
}
