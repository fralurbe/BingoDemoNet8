@echo off
dotnet publish -c Release -r win-x64 --self-contained -p:PublishSingleFile=true
echo.
echo ¡EXE LISTO! ? bin\Release\net8.0-windows\win-x64\publish\BingoDemoNet8.exe
pause