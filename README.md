# rust-to-unity
Simple template for using Rust code from Unity/C# code

Includes template for calling Rust functions from unity and allocating/freeing Rust structs from Unity. Arrays still TODO.

Repository contains currently the Rust DLL only for Windows (64-bit). You need to compile the Rust lib for other platforms.

Tested with nightly Rust but there's no reason it wouldn't work on stable as well.

## Usage

Run `cargo build`(debug) or `cargo build --release`(release) in `rust` directory. The library file will be in `target/debug/rust_lib.dll` in Windows and `target/debug/librust_lib.dylib` in MacOS, or in `target/release` directory if built with `--release`.

Copy the library file to unity project's `Assets` folder and you should be good to go. See sources for usage.

