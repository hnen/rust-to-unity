use std::mem;

#[repr(C)]
pub struct MyRustStruct {
    i0 : i32,
    i1 : i32,
    f0 : f32
}

#[no_mangle]
pub extern "C" fn my_rust_struct_new() -> *mut MyRustStruct {
    let my_rust_struct = MyRustStruct {
        i0: 1, i1: 2, f0: 1.0
    };
    unsafe { mem::transmute( Box::new( my_rust_struct ) ) }
}

#[no_mangle]
pub extern "C" fn my_rust_struct_free(my_rust_struct_ptr : *mut MyRustStruct) {
    let _obj : Box<MyRustStruct> = unsafe { mem::transmute(my_rust_struct_ptr) };
    // _obj gets dropped here
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn test_my_rust_struct() {
        let ptr = my_rust_struct_new();
        my_rust_struct_free(ptr);
    }
}

