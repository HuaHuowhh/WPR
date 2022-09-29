# WPR proto 1

WPR is a WP7-8 XNA app runner. This is only fork of [WPR](https://github.com/8212369/WPR), not the original. 


## Features

- Installing WP7-8 **decrypted** XNA XAPs locally on your machine.
- Earning achievements locally for Xbox Live games, with a pop-up appear everytime achievement is unlocked.


## Screenshots

![Shot 1](Images/shot1.png)
![Shot 2](Images/shot2.png)
![Shot 3](Images/shot3.png)
![Shot 4](Images/shot4.png)
![Shot 5](Images/shot5.png)
![Shot 6](Images/shot6.png)
![Shot 7](Images/shot7.png)


## My 2 cents

- I temporally removed Android target (Reason: the multi-platform solution was too hard to assemble for me!)
- I solved the "no-sound" problem (by copying SDL2.dll, FNA3D.dll, FAudio.dll and FFMPEG.exe onto app dir.)
- RE folder added (Reverse Engeneering; consists of Commit0 and Commit1)

    
## Building (Desktop) 

- I used the newest VS 2022 Preview to build this super-hard solution
- Build these libraries and place them under the same folder as the executable
- Place FFMPEG executable (you can download from their website or make a custom version with WMA->OGG conversion supported)
- Beside submodules included in this repostiory, this application depends on these native DLLs:
    * FNA3D
    * FAudio
    * libtheorafile 

    
## This runner existence :: words from the [author/owner/main developer](https://github.com/8212369/) 

"
- It's for fun. If you are nostaglia mostly about achievements earning like me, you can try it out. There are some old games that is not released on Android or iOS, or some games that seems superior than Android or iOS version (I prefer Skulls of the Shogun on WP actually).
- However, resolution scaling is not yet implemented (game renders either in 480x800 or so...), but it's fun!
"


## ..

AS IS. No support. RnD only. DIY.


## .

[m][e] 2022 , September

