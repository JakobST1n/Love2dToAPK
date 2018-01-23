# Install

## Step One
Unzip the release-zip, or go to the `publish`-folder in the source. And run `setup.exe`.

## Step Two
If the app don't launch automatically, launch it from the start-menu

## Step Three
Click the `dirs` button in the menu strip, a explorer window should now be opened with an empty folder.
Copy the contents from the `tools`-folder, this is located in the same place as `setup.exe`.

## Step Four
The should now be ready to use.


# Usage

Basic usage
-----------
- Select the folder that contains your love-source, press `Select project dir`.
- Press `Compile` or `Ctrl + Shift + F5`.
- The app should now compile, a output-window will open and show status of the process.
- It will try to install it on any connected android-phone.

AndroidManifest and Custom Icon
--------------------------------
If you want to change settings of the app, press the `dirs`-button. Go to `tools\love-android-sdl2\` copy the file 'AndroidManifest.xml` into you project directory. And edit the file in you project-dir

I have not implemented a custom-icon possibility yet. You could change it in the `tools\love-android-sdl2` dir, but this would affect all apps.

Settings
--------
There are two options in the settings of the app itself.

- `Window always on top` - This makes the app always stay on top of other apps... `[Default: No]`
- `Close output-window if build was successfull` - This closes the output-window if it thinks the build was successfull, this option assumes that the compilation succeded. And it does not care if it was able to push to your phone. `[Default: No]`
