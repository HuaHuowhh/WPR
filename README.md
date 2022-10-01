# WPR proto 2

WPR is a WP7-8 XNA app runner. This is only fork of [WPR](https://github.com/8212369/WPR), not the original. 

This is only my little "Avalonia Android/Desktop framework" research + micro-development (or re-development?))))

## Features

- Installing WP7-8 **decrypted** XNA XAPs locally on your machine. Most encripted XAP files are unusable :(
- Earning achievements locally for Xbox Live games, with a pop-up appear everytime achievement is unlocked. :)


## Screenshots

![Shot 1](Images/shot1.png)
![Shot 2](Images/shot2.png)
![Shot 3](Images/shot3.png)
![Shot 4](Images/shot4.png)
![Shot 5](Images/shot5.png)
![Shot 6](Images/shot6.png)
![Shot 7](Images/shot7.png)
![Shot 8](Images/shot8.png)


## My 2 cents

- Android target "returned"/enabled again (Reason: the Avalonia's multi-platform features research)
- Strange "Android-depandant bug" at About page was fixed by adding only 1 line of code :)
- I solved the "no-sound" problem (by copying SDL2.dll, FNA3D.dll, FAudio.dll and FFMPEG.exe onto app dir.)
- RE folder added (Reverse Engeneering; consists of Commit0 and Commit1)

    
## Building 

### Windows (Desktop) target  

- I used the newest VS 2022 Preview to build this super-hard src code
- Build these libraries and place them under the same folder as the executable
- Place FFMPEG executable (you can download from their website or make a custom version with WMA->OGG conversion supported)
- Beside submodules included in this repostiory, this application depends on these native DLLs:
    * FNA3D
    * FAudio
    * libtheorafile 

### Android target 

- I also used the newest VS 2022 Preview to build this mind-blowing code. Plus I installet Avalonia extension from VS Marketplace
- I "lost" all my code fixes because of I repeat to fork the original WPR (with ALL java bindings). I use this command (at cmd line):

git clone --recursive https://github.com/8212369/WPR

- I specially deleted .gitmodules file for reducing the problems when I'll be upload the result onto GitHub repo.
- Before building I check that .NET 6 installed (recovered by VS) in my system.


## TODO

- Find and tranfer "bugfixes" from /RE/WPR to /Src/WPR
  
    
## This runner existence :: words from the [author/owner/main developer](https://github.com/8212369/) 

" It's for fun. If you are nostaglia mostly about achievements earning like me, you can try it out. There are some old games that is not released on Android or iOS, or some games that seems superior than Android or iOS version (I prefer Skulls of the Shogun on WP actually).
 However, resolution scaling is not yet implemented (game renders either in 480x800 or so...), but it's fun!" :: Lin Yan (8212369)


## :: ::

AS IS. No support. RnD only. DIY.


## ::

[m][e] 2022 , October

