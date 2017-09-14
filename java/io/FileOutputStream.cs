using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace java.io
{
    public class FileOutputStream : OutputStream
    {
        public FileOutputStream(String name)
        {
            mAndroidJO = new AndroidJavaObject("java.io.FileOutputStream", name);
        }

        public FileOutputStream(String name, Boolean append)
        {
            mAndroidJO = new AndroidJavaObject("java.io.FileOutputStream", name, append);
        }
    }
}
