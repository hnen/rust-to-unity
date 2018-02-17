
#[no_mangle]
pub extern "C" fn my_rust_func(f: f32) -> f32 {
    f * 2.0
}


#[cfg(test)]
mod tests {
    use super::*;
    #[test]
    fn test_test_func() {
        assert_eq!(my_rust_func(2.0), 4.0);
    }
}
