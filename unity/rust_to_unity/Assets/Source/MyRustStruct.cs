using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace RustToUnity
{

    public class MyRustStruct : IDisposable
    {
        private unsafe PtrMyRustStruct * ptr;

        public int i0 { get { unsafe { return ptr->i0; } } }
        public int i1 { get { unsafe { return ptr->i1; } } }
        public float f0 { get { unsafe { return ptr->f0; } } }

        private unsafe MyRustStruct(PtrMyRustStruct * nativePtr)
        {
            this.ptr = nativePtr;
        }

        public static MyRustStruct Create()
        {
            unsafe {
                return new MyRustStruct(MyRustStructAllocator.New());
            }
        }

        void IDisposable.Dispose()
        {
            unsafe {
                MyRustStructAllocator.Free(ptr);
            }
        }
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct PtrMyRustStruct
    {
        public int i0;
        public int i1;
        public float f0;
    }

    public static class MyRustStructAllocator
    {

        [DllImport("rust_lib")]
        private unsafe static extern PtrMyRustStruct* my_rust_struct_new();

        [DllImport("rust_lib")]
        private unsafe static extern float my_rust_struct_free(PtrMyRustStruct* ptr);

        static IntPtr test_ptr = IntPtr.Zero;

        public unsafe static void Free(PtrMyRustStruct* test)
        {
            my_rust_struct_free(test);
        }

        public unsafe static PtrMyRustStruct * New()
        {
            return my_rust_struct_new();
        }

    }
}
