--[[-- This file shows examples of settings you can adjust.

Configuration files with preferences are loaded in the following order:
1. cfg/user.lua (system-wide configuration)
2. HOME/.zbstudio/user.lua (per-user configuration)
3. -cfg <lua code fragment|filename> (command line configuration)

See [configuration](http://studio.zerobrane.com/doc-configuration.html) page for information about location of configuration files.

--]]--

-- to modify a key mapping; see the full list of IDs in src/editor/keymap.lua
-- starting from v0.95, ID.<menuid> can be used instead of G.ID_<menuid>
keymap[ID.RUN] = "Ctrl-R"
keymap[ID.REPLACE] = nil

-- to change font size to 12
editor.fontsize = 14 -- this is mapped to ide.config.editor.fontsize
--editor.fontname = "Courier New"
filehistorylength = 20 -- this is mapped to ide.config.filehistorylength

-- to specify full path to love2d *executable*; this is only needed
-- if the game folder and the executable are NOT in the same folder.
path.love2d = '../tools/love-old-win/love.exe'

-- to disable wrapping of long lines in the editor
editor.usewrap = true

-- to specify language to use in the IDE (requires a file in cfg/i18n folder)
language = "en"

-- do not offer dynamic (user entered) words; set to false to collect all words from all open editor tabs and offer them as part of the auto-complete list.
acandtip.nodynwords = true

-- to change the default color scheme; check tomorrow.lua for the list
-- of supported schemes or use cfg/scheme-picker.lua to pick a scheme.
-- (no longer needed in v1.21+) local G = ... -- this now points to the global environment
styles = loadfile('cfg/tomorrow.lua')('Tomorrow')

--TURN OFF UNDERLINING
styles.indicator = {}

-- also apply the same scheme to Output and Console windows
stylesoutshell = styles

-- to set compact fold that doesn't include empty lines after a block
--editor.foldcompact = true

-- set the default interpreter used for new projects
interpreter = "love2d"

-- https://github.com/pkulchenko/ZeroBraneStudio/issues/645
ide.interpreters.love2d.skipcompile=true

-- don't open output on run
activateoutput = false
