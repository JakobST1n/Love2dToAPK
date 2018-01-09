@echo off

setlocal
set ANT_HOME=%~dp0\tools\ant
set JAVA_HOME=%~dp0\tools\jdk-win
set ANDROID_HOME=%~dp0\tools\android-win
set PATH=%PATH%;%ANT_HOME%\bin

cd tools\love-android-sdl2

call ant debug

