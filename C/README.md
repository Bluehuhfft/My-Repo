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
```
You have to install GCC and G++. I recommend `MinGW`
Its actually quite complicated so click [here](https://www.youtube.com/watch?v=jvg4VtYEhKU). But this video also shows how to setup VSCode with c++, but honestly
you don't need that. Also, if you're on Linux, you already have gcc and g++ installed by default.


# How to run on Windows:
```shellscript
C:\Windows\User> cd Downloads
C:\Windows\User\Downloads> cd Folder
C:\Windows\User\Downloads\Folder> gcc Main.c -o Main.exe -lm
```
If you don't use (-lm) there will be a linking error while compiling.
I'm assuming that your selected destination for the folder was 'Downloads'.
Please replace 'Folder' with the name of the folder you were given. Eg.

```shellscript
C:\Windows\User\Downloads> cd calculator
```

# How to run on Linux:
(1): Open the folder in your file explorer.
(2): Right-click in the empty space in the folder and select `Open in Terminal`

Type the following:
``` shellscript
User@Computer:~$ gcc Main.c -lm
```
If you don't use (-lm) there will be a linking error while compiling.
Then, a `a.out` file will be generated. Please follow the following step to execute that file:

```shellscript
User@Computer:~$ ./a.out
```
