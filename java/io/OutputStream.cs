using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace java.io
{
    abstract public class OutputStream
    {
        internal AndroidJavaObject mAndroidJO;

        public AndroidJavaObject AndroidJO
        {
            get
            {
                return mAndroidJO;
            }
        }

        public void Close()
        {
            mAndroidJO.Call("close");
        }

        public void Flush()
        {
            mAndroidJO.Call("flush");
        }

        public void Write(byte[] bytes)
        {
            mAndroidJO.Call("write", bytes);
        }

        public void Write(byte[] bytes, int off, int len)
        {
            mAndroidJO.Call("write", bytes, off, len);
        }

        public void Write(int data)
        {
            mAndroidJO.Call("write", data);
        }
    }
}
