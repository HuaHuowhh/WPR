﻿using System;
using System.Diagnostics;

namespace Microsoft.Phone.Shell
{
    public class ShellTileData
    {
        public void set_Title(ShellTileData data)
        {
            Debug.WriteLine("[i] data : " + data);
        }

        //RnD
        public void set_Title(string text)
        {
            Debug.WriteLine("[i] text : " + text);
        }
    }
}
