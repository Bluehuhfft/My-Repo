# Welcome Stranger!
Please make sure that you have installed GCC and G++ to run these files! To check, if you have them installed:
``` shellscript
C:\Windows\User> gcc --version
C:\Windows\User> g++ --version
```
If it shows up: (Or something similar)
``` shellscript
C:\Windows\User> gcc --version
Error: 'gcc' is not recognized as an external or bash command.

C:\Windows\User> g++ --version
Error: 'g++' is not recognized as an external or bash command.
```
You have to install GCC and G++. I recommend `MinGW`
Its actually quite complicated so click [here](https://www.youtube.com/watch?v=jvg4VtYEhKU). But this video also shows how to setup VSCode with c++ and c, but honestly
you don't need that. Also,if you're using Linux, you already have gcc and g++ installed, by default.


# How to run on Windows:
```shellscript
C:\Windows\User> cd Downloads
C:\Windows\User\Downloads> cd Folder
C:\Windows\User\Downloads\Folder> g++ Main.cpp -o Main.exe -lm
```
If you don't use (-lm) there will be a linking error while compiling.
I'm assuming that your selected destination for the folder was 'Downloads'.
Please replace 'Folder' with the name of the folder you were given. Eg.

```shellscript
C:\Windows\User\Downloads> cd calculator
```

# How to run on Linux:
(1): Open the folder in your file explorer. (You already have G++ and GCC installed by default!)
(2): Right-click in the empty space in the folder and select `Open in Terminal`

Type the following:
``` shellscript
User@Computer:/Downloads/Calulcator$ g++ Main.cpp -lm
```
If you don't use (-lm) there will be a linking error while compiling. Only some files use this but yea, I hope you understand.
Then, a `a.out` file will be generated. Please follow the following step to execute that file:

```shellscript
User@Computer:/Downloads/Calculator$ ./a.out
```
