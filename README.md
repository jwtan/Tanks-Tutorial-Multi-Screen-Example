# Tanks! Tutorial Multi-Screen Example
This example project is built upon the [Tanks! Tutorial](https://assetstore.unity.com/packages/essentials/tutorial-projects/tanks-tutorial-46209 "Tanks! Tutorial") project and demonstrates how to implement simple multi-screen functionality by rendering the overhead camera to a second display.

This project was tested on the [ASUS ROG Phone II](https://www.asus.com/Phone/ROG-Phone-II/ "ASUS ROG Phone II") with TwinView dock.

Rendering to a specific display was easily achieved by using [Camera.SetTargetBuffers](https://docs.unity3d.com/ScriptReference/Camera.SetTargetBuffers.html "Camera.SetTargetBuffers") with a target display found in [Display.displays](https://docs.unity3d.com/ScriptReference/Display-displays.html "Display.displays").

### Project Details
Unity version: 2019.3.2f1
Platform: Android

### Project Layout
- `Assets/_Multi-Screen/` This folder contains most of the project files (code, prefabs, scenes etc.)
- `Assets/Scripts/Managers/TankManager.cs` This original Tanks! Tutorial script was edited to insert some setup code

### Demonstration

### Special Thanks
[Virtual Plug and Play Joystick](https://assetstore.unity.com/packages/tools/input-management/virtual-plug-and-play-joystick-114288 "Virtual Plug and Play Joystick") on the Unity Asset Store
