# C# Name Sorter

## Purpose

A console application to sort a list of names loaded from a file.  
The sort is implemented in the following order:

1. Last Name
2. Given Name 1
3. Given Name 2
4. Given Name 3

Names without a given name or more than 3 given names are rejected.  
The results are printed to screen.  
Additionally, the results are written to a file name "sorted-names-list.txt".  
The file will be located in the executing directory.

## Download the project from GitHub

1. Click the green "<> Code" button.
2. Select "Download ZIP"
3. Unzip the download.

## Running the program

The application targets the .NET 8.0 core runtime.

### Windows (tested on Windows 11)

Assumes there is a file called "unsorted-names-list.txt" in the "release-build" directory.

1. Open either Powershell or Command Prompt and navigate to the "release-build" directory:

   ```
   > cd ...\name-sorter\release-build
   ```

   - To run directly from the commandline,
     set the "PATH" variable under "environment variables" and point it to the executable. [_instructions over here_](https://www.c-sharpcorner.com/article/how-to-addedit-path-environment-variable-in-windows-11/)  
     Run:

     ```
     name-sorter ./unsorted-names-list.txt
     ```

2. Run the following command (**"PATH" variable not set**):  
   (You can replace "./unsorted-names-list.txt" with a filepath of your own.)

   ```
   > ./name-sorter ./unsorted-names-list.txt
   # or
   > .\name-sorter .\unsorted-names-list.txt
   # or
   > ./name-sorter.exe ./unsorted-names-list.txt
   # or
   > .\name-sorter.exe .\unsorted-names-list.txt
   ```

### Linux (tested on Ubuntu 24.04)

Assumes you have the the .NET 8.0 core runtime installed.  
Assumes there is a file called "unsorted-names-list.txt" in the "release-build" directory.

1. Navigate to the "release-build" directory:

   ```
   $ cd .../name-sorter/release-build
   ```

2. Run the following command:

   ```
   $ dotnet name-sorter.dll ./unsorted-names-list.txt
   ```
