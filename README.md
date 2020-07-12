This is a Chrome extension (written in F#) that shows a Xamarin.Forms page inside a popup. Xamarin.Forms and F# are compiled to WebAssembly via Ooui.Forms and Mono Wasm.

## How to install:
1. Download the latest release (.zip) from https://github.com/traxium/OouiWasmChromeExtension/releases
1. Unpack (e.g. to `~/OouiWasmChromeExtension-v0.2.0`)
1. In Chrome go to `chrome://extensions/`
1. Enable [Developer mode] (if not enabled)
1. Click [Load unpacked]
1. Go inside the unpacked folder (e.g. inside `~/OouiWasmChromeExtension-v0.2.0`)<br />
   (do not go inside `~/OouiWasmChromeExtension-v0.2.0/managed` because Chrome wants you to point to a folder containing `manifest.json`)
1. Click [Select Folder]/[Open] button

## How to build:
1. `git clone --recurse-submodules https://github.com/traxium/OouiWasmChromeExtension.git`<br />
   (don't forget `--recurse-submodules` part because just `git clone https://github.com/traxium/OouiWasmChromeExtension.git` won't work)
   1. `dotnet build OouiWasmChromeExtension/Frontend/Frontend.fsproj`
1. In Chrome go to `chrome://extensions/`
   1. Enable [Developer mode] (if not enabled)
   1. Click [Load unpacked]
   1. Point to `...\OouiWasmChromeExtension\Frontend\bin\Debug\netcoreapp3.1\dist`<br />
   (do not point to `...\OouiWasmChromeExtension\Frontend\bin\Debug\netcoreapp3.1\dist\managed` because Chrome wants you to point to a folder containing `manifest.json`)
   1. Click [Select Folder]/[Open] button
