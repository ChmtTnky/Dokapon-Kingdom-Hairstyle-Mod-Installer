## Hairstyle Mod Installer Version 3.0

A program with all of the necessary tools and functions required to install hairstyle mods for Dokapon Kingdom.

Big thanks to Yackerw for creating the Archive tools.

## Prerequisites

- Dolphin Emulator (https://dolphin-emu.org/)

- WIT: Wiimms Tools (https://wit.wiimm.de/)

- Microsoft .NET SDK 6.0 (https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

- Optional: Some hairstyle mods! (https://gamebanana.com/games/15747)

## Instructions

**Extract the Game Files**

- Click "Select ISO/WBFS" and select the iso or wbfs file of Dokapon Kingdom that you wish to modify

- Click "Extract Game Files", at which point a Command Prompt will open and automatically run the command to extract the files

- The extracted files will be placed in a new folder called DokaponFiles in the same directory as the executable

**Unpack the GAME.PAC**

- Click "Select GAME.PAC" and select the GAME.PAC located inside the newly created DokaponFiles folder

- Click "Select GAME.PAH" and select the GAME.PAH located inside the newly created DokaponFiles folder

- Click "Unpack GAME.PAC", at which point the program will extract the files contained within the GAME.PAC

- The extracted files will be placed in a new folder called PACFiles in the same directory as the executable

**Install the Mods**

- Click "Select Model File" and select the IGB file of the hairstyle you wish to install

- Click "Select Model Files Folder" and select the newly created PACFiles folder

- Select the hairstyle from the dropdown list that you wish to replace

- DO NOT UNCHECK "Delete PIM Files?". Just ignore the option unless you have a reason not to.

- Click "Apply Mod" to install the hairstyle

- Repeat this step for every hairstyle you wish to install

**Repack the GAME.PAC**

- Select "Repack GAME.PAC", at which point the program will begin repacking the GAME.PAC and GAME.PAH using the contents of PACFiles

- The newly created GAME.PAC and GAME.PAH will automatically replace the previously selected GAME.PAC and GAME.PAH

**Remake the WBFS**

- Click "Select Game Files Folder" and select the DokaponFiles folder

- Click "Create WBFS", at which point a Command Prompt will open and automatically run the command to remake the WBFS

- The newly created WBFS called DokaponKingdom.wbfs will be placed in the same directory as the executable

**Add the required AR Code**

- In Dolphin, right click Dokapon Kingdom, select Properties, then select Add New Code

- Add the folowing AR code to fix how the game loads files: 04212410 48000024

- Make sure cheats are enabled in your Dolphin Configuration settings

**You can now open the modded DokaponKingdom.wbfs with Dolphin**

## Notes

- Usage of the hairstyle unlock AR code is highly recommended

- The "Delete PIM Files?" option is there for the sake of completeness. Do not uncheck it.

- The program might take more time to finish if you have a slower computer. Just be patient.

- There is no option to create an ISO file because it is larger than a WBFS and it serves the same function.
