using UnityEngine;

namespace java.io
{
    public class ByteArrayOutputStream : OutputStream
    {
        public ByteArrayOutputStream()
        {
            mAndroidJO = new AndroidJavaObject("java.io.ByteArrayOutputStream");
        }

        public ByteArrayOutputStream(int size)
        {
            mAndroidJO = new AndroidJavaObject("java.io.ByteArrayOutputStream", size);
        }

        public void Reset()
        {
            mAndroidJO.Call("reset");
        }

        public void Size()
        {
            mAndroidJO.Call("size");
        }

        public byte[] ToByteArray()
        {
            return mAndroidJO.Call<byte[]>("toByteArray");
        }

        override public string ToString()
        {
            return mAndroidJO.Call<string>("toString");
        }

        public string ToString(string charset)
        {
            return mAndroidJO.Call<string>("toString", charset);
        }

        public void WriteTo(OutputStream outstream)
        {
            mAndroidJO.Call("writeTo", outstream.AndroidJO);
        }
    }
}
