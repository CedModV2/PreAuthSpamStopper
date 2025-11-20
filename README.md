# PreAuthSpam Stopper  

> [!WARNING]  
> This plugin is **NOT** needed when using CedMod, it already has this functionality.

Are you tired of your console being filled with:  
  
<img width="677" height="87" alt="image" src="https://github.com/user-attachments/assets/fbd559a6-e17d-4430-a196-42af5fe00981" />
  
Installing this plugin will hide invalid preauth attempts after 5 failures, and will continue hiding them until a specific period of time passes AND if the spam stops.

# Installation
Download the latest [Release](https://github.com/CedModV2/PreAuthSpamStopper/releases)
Put `PreAuthSpamStopper.dll` in `.config/SCP Secret Laboratory/LabAPI/plugins/global` on linux.  
or `.%appdata%/SCP Secret Laboratory/LabAPI/plugins/global` on windows.  

If you do not have harmonly installed, put `0Harmonly.dll` in 
in `.config/SCP Secret Laboratory/LabAPI/dependencies/global` on linux.  
or `.%appdata%/SCP Secret Laboratory/LabAPI/dependencies/global` on windows.  

Restart the server, thats it.
