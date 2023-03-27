@echo off
taskkill /im Ordisoftware.Nutrition.Manager.exe
ping localhost -n 3 >NUL
start "" ..\Bin\Ordisoftware.Nutrition.Manager.exe --reset