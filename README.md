# Maverick

.NET / C# script to close software that contain social aspects in them. Ones like Discord, Steam, Slack etc.

The script is build for x86 Windows, but earlier version worked well enough on Mac too.

## Motivation

Sometimes you'd just prefer to close them all in one click without thinking about the two dozen subprograms and processes they have started. Or feel the need to see if they're still running in background and giving your contacts the false impression that you're available online.

## Build the executable

`dotnet publish src -o dist`

## Running Maverick

Just running the exe produces output like this:
```
Closed 13 program(s)
- steam
- steamwebhelper
- steamwebhelper
- steamwebhelper
- steamwebhelper
- Discord
- Discord
- Discord
- Discord
- Discord
- steamwebhelper
- Discord
- steamwebhelper
Failed to close 1 program(s)
- SteamService
```

Should there be failures, running the program as an administrator should do the trick.


## Whats in the name?

From Merriam-Webster dictionary: *maverick is an independent individual who does not go along with a group or party.*
