@echo off
echo reading drive E
timeout 2 >nul
:check
if not exist "E:\CWIN" goto open
if exist "E:\CWIN" goto lol

:lol
cls
echo loading cwin.exe cuz its in the start menu
timeout 2 >nul
E:\CWIN\bin\Debug\CWIN.exe
exit

:open
cls
echo Please plug in the cwin dev tools drive into your computer to continue
timeout 2 >nul
goto :check