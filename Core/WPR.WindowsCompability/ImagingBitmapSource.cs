// System.Windows.Media.Imaging "imitation"

using System;


namespace WPR.WindowsCompability
{
    // projection: System.Windows.Media.Imaging
    public class BitmapSource //RnD : static
    {
        public BitmapSource()
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
        //public static void SetSource(System.IO.Stream stream)
        //{       
            //TODO
        //   return;
        //}

        //public static void SetSource()
        //{
        //    //TODO
        //    return;
        //}


    }

    //RnD
    public class BitmapSource2 : BitmapSource
    {
        //public static Action<DisplayOrientation>? RequestOrientation;

        public BitmapSource2()
            : base()
        {

        }

        public void SetSource()
        {
            //TODO
            return;
        }

        public void SetSource(System.IO.Stream stream)
        {
            //TODO
            return;
        }

        public Int32 get_PixelWidth()
        { 
            return (Int32)1; //RnD
        }

        public Int32 get_PixelHeight()
        {
            return (Int32)1; //RnD
        }

    }
}

