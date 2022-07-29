*Code Louisville Software Development 1 Project*

Project Requirements Fulfilled

1. Master Loop (Control the typing test by using a While loop until the user inputs "N"
2. Populates list from text file (Then set to an array in line 30)
3. Can read data from a text file
4. Analyzes how many words are in a body of text (If you have a words.txt created)
5. Logs info from the typing test into a "log.txt"



Targets .NET 6.0
Designed for Windows OS use
Easiest way to run is debug from the .sln file as of turn in date. This method has been tested on another machine running Windows 10 19044.1826

This program lets the user choose how many words they would like to include in the typing test and calculates stats based on their results. First, it will check " C:\Users\Public " for a
words.txt file. If no words.txt file is found in this location, it will default to the hard coded words "Dog", "Cat", and "Horse". If a words.txt file is found, the program determines how many
words there are (each line is a "word"), and uses these words in the typing test. If running through the test for the first time, a "Log.txt" file will be created in Documents and will log stats from the users
performance. If the file already exists, the stats will be appended. 

The three required functions are CalculateWPM, CalculatePercentage and EndGameMessage.

Note that the current calculation within the program's logic works properly, but I will need to work on implementing a "true" words per minute calculation. 
