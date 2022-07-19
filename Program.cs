using System.Diagnostics;
using static TypingGame.StartGame;

// See https://aka.ms/new-console-template for more information


string prompt = "This is the prompt you will be typing and I hope it is a good time for you to work on your typing. I hope this works to calculate the correct WPM!";
int wordCount = prompt.Split(' ').Length;

string logTime;
string logWPM;
int calculatedWPM;


GameStart();



Console.WriteLine("Hello, welcome to this typing game!");
Console.WriteLine("You will be typing the below sentence:");
Console.WriteLine("--------");
Console.WriteLine(prompt);
Console.WriteLine("--------");
Console.WriteLine("Ready? (Y/N)");
string? startString = Console.ReadLine();



Stopwatch stopwatch = new Stopwatch();


if (startString == "y" || startString == "Y")           // If user starts game...
{

    stopwatch.Start();

    string? input = Console.ReadLine();


    if (input == prompt)
    {
        Console.WriteLine("Success!");
        TimeSpan timeSpan = stopwatch.Elapsed;
        stopwatch.Stop();
        Console.WriteLine("It took you {0:00}:{1:00}:{2:00}.{3}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);

        logTime = timeSpan.ToString();
        calculatedWPM = CalculateWPM(prompt, wordCount, timeSpan);
        logWPM = CalculateWPM(prompt, wordCount, timeSpan).ToString();

        Console.WriteLine("Calculated WPM:" + CalculateWPM(prompt, wordCount, timeSpan));


    }
    else                                                // 
    {
        Console.WriteLine("WRONG!");
    }

}

else
{
    Console.WriteLine("That is not a Y!");
}



int GetTimeElapsedInSeconds()
{
    return (int)stopwatch.Elapsed.TotalSeconds;
}

 float GetTimeElapsedInMinutes()
{
    return GetTimeElapsedInSeconds() / 60f;
}


 int CalculateWPM(string wordPrompt, int wordCount, TimeSpan time )
{

    double timeElapsed = (double)GetTimeElapsedInMinutes();

    double wordsPerMinute = wordCount / timeElapsed;

    int wpmRounded = (int)Math.Round(wordsPerMinute, 0);


    return wpmRounded;


}
