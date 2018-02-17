using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace RustToUnity
{
    public static class MyRustFunc
    {
        [DllImport("rust_lib")]
        private static extern float my_rust_func(float x);

        public static float Call(float x)
        {
            return my_rust_func(x);
        }
    }
}
