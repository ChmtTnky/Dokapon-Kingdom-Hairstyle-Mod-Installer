Hairstyle Mod Installer Version 1.0

A program to speed up the process of installing hairstyle mods for Dokapon Kingdom

Prerequisites

Dolphin Emulator (https://dolphin-emu.org/)

Wiimms Tools (https://wit.wiimm.de/)

Microsoft .NET SDK 6.0 (https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

Dokapon Archive Tools

**Instructions**

1. Extract the Game Files

Click "Select ISO/WBFS" and select the iso or wbfs file of Dokapon Kingdom that you wish to modify

Click "Extract Game Files", at which point a Command Prompt will open and automatically run the command to extract the files

The extracted files will be placed in a folder called DokaponFiles

2. Unpack the GAME.PAC

Currently, the Archive Tools section is incomplete. To unpack the GAME.PAC use the Dokapon Archive Tools.

3. Install the Mods

Click "Select Model File" and select the IGB file of the hairstyle you wish to install

Click "Select Model Files Folder" and select the folder containing the model files extracted from the GAME.PAC

Select the hairstyle from the dropdown list that you wish to replace

Click "Apply Mod" to install the hairstyle

Repeat this step for every hairstyle you wish to install

4. Repack the GAME.PAC
Currently, the Archive Tools section is incomplete. To repack the GAME.PAC use the Dokapon Archive Tools.

5. Remake the WBFS

Click "Select Game Files Folder" and select the DokaponFiles folder

Click "Create WBFS", at which point a Command Prompt will open and automatically run the command to remake the WBFS

The newly created WBFS will be called DokaponKingdom.wbfs

6. Add the required AR Code

In Dolphin, right click Dokapon Kingdom, select Properties, then select Add New Code

Add the folowing AR code to fix how the game loads files: 04212410 48000024

Make sure cheats are enabled in your Dolphin Configuration settings

You can now open the modded DokaponKingdom.wbfs with Dolphin

**Notes**

- The "Delete PIM Files?" option is there for the sake of completeness. Do not uncheck it.

- There is no option to create an ISO file because it is larger than a WBFS and it serves the same function.

**Future Plans**

- Dokapon Archive Tools integration

- Job and Prank hair replacement
