This is a Chrome extension (written in C#) that shows a Xamarin.Forms page inside a popup. Xamarin.Forms and C# are compiled to WebAssembly via Uno.platform and Mono Wasm.

## How to build
1. Have .NET 3.1 SDK installed and accessible in your PATH
1. Run `make.bat`
1. Your extension will be generated in the `publish_result` subfolder at the root of the repo

## How to install:
1. In Brave/Chrome go to `chrome://extensions/`
1. Enable [Developer mode] (if not enabled)
1. Click [Load unpacked]
1. Go inside the publilshed folder above
1. Click [Select Folder]/[Open] button
