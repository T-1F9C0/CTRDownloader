# CTRDownloader

This is the library used to download *Cheese Terminator: Reloaded*'s packages. It's based on [UUPMediaCreator](https://github.com/gus33000/UUPMediaCreator).

## Build (TEMP)

```
dotnet publish -r win-arm64 -c Release /p:NativeLib=Static /p:self-contained=true /t:LinkNative
```
