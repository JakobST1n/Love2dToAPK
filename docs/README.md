# Download 
Click one of the download-buttons to the right, if you want to get the source. +
To download the latest release to to the [release-page](https://github.com/JakobS1n/Love2dToAPK/releases).
# Install
## Step One
Unzip the downloaded file, and double-click `setup.exe`. (You could also compile from source, you will then find the `setup.exe` in the `publish`-folder.)

## Step Tw]
If the program doesn't start by itself. Find it in the start menu, and open it.

## Step Three
Click the button named `dirs` in the menu-strip of the app. Now, a explorer-window with an empty folder should open. Copy the contents from the `tools`-folder into the window into the now open explorer-window. The `tools`-folder is located in the same place as `setup.exe`.

## Step Four
The program should now be ready to compile!

# Usage

Basic usage
-----------
- Select the folder that contains your love-source, `Select project dir`.
- Press `Compile` or `Ctrl + Shift + F5`.
- The app should now compile, a output-window will open and show status of the process.
- It will try to install it on any connected android-phone.

AndroidManifest and Custom Icon
--------------------------------
If you want to change settings of the app, press the `dirs`-button. Go to `tools\love-android-sdl2\` and copy the file 'AndroidManifest.xml` into you project directory. You can now make any changes you want to the file in your project-directory.

I have not implemented a custom-icon possibility yet. You could change it in the `tools\love-android-sdl2` dir, but this would affect all apps.

Settings
--------
There are two options in the settings of the app itself.

- `Window always on top` - This makes the app always stay on top of other apps... `[Default: No]`
- `Close output-window if build was successfull` - This closes the output-window if it thinks the build was successfull, this option assumes that the compilation succeded. And it does not care if it was able to push to your phone. `[Default: No]`
