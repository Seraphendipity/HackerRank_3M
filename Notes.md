# Notes


## VSCode Things

I want to create a custom extension to have my own debugger from Debugger Configuration dropdown. I like C# and its tasks, but it defaults to `internalConsole` rather than `integratedTerminal`, as well as needing the line `"internalConsoleOptions": "neverOpen",`. Moreover, it seems there *should* be a way to add such a configuration dropdown without it. While you can add a launch configuration to user settings, it is then not transferred with the project. All it needs is to be able to look at that, and instead of directly using, add it as a configuration choice from `Debug: Add Configuration`.