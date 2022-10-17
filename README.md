# EnormousSibling

Trombone Champ mod: Change the hit accuracy text

Trombone Champ modding Discord: https://discord.com/invite/Jy36kBwm

## How to configure

1. Install as usual: BepInEx and all that
2. Run the game
3. Close the game
4. Open BepInEx/config/EnormousSibling.cfg in a text editor and change the values
    - Result will be capitalized
    - Anything over 10 letters may get cut off
    - Numbers and symbols ok: `A = 100%`
    - Spaces ok: `B = PRETTY GOOD`
5. Run the game

## Pre-build setup

1. Create a folder `lib` in the same directory as the `.csproj`
2. Copy in these files from `TromboneChamp_Data/Managed`
    - `0Harmony.dll`
    - `Assembly-CSharp.dll`
    - `UnityEngine.CoreModule.dll`
    - `UnityEngine.dll`
    - `UnityEngine.UI.dll`
3. Open the `.csproj` in your preferred IDE and build as normal
