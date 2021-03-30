dotnet restore App8\App8.sln
dotnet publish App8\App8.Wasm\App8.Wasm.csproj -o "publish_result\"
dotnet fsi "scripts\post-build.fsx" browserExtensionAssets publish_result