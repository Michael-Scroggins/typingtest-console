using System.Diagnostics;
using System.Text;
using System.Linq;
using TypingGame;

string[] words = { "Blue", "Car", "Test", "Together" };
var stopWatch = new Stopwatch();
Random random = new Random();

Stats stats = new Stats();


Console.WriteLine("Do you want to start the test? (Y/N)");

string? input = Console.ReadLine();
string? gameDecision = input.ToUpper();




string word;


while (gameDecision != "N")

{
    stats.Correct = 0;
    stats.Missed = 0;

    int numberOfWordsToType = 0;

    double elapsedTime = 0;
    double wordsPerMinute = 0;

    Console.WriteLine("How many words do you want to type?");
    numberOfWordsToType = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Press enter to start!");
    Console.ReadLine();

    stopWatch.Start();

    for (int i =0; i < numberOfWordsToType; i++)
    {
        word = words[random.Next(words.Length)];
        Console.WriteLine(word);
        if (Console.ReadLine() == word)
        {
            stats.Correct++;
        }

        else
        {
            stats.Missed++;
        }

        Console.WriteLine("------------------------------------------------");
    }

    stopWatch.Stop();
    elapsedTime = stopWatch.Elapsed.TotalMinutes;
    wordsPerMinute = numberOfWordsToType / elapsedTime;
    Console.Clear();
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine("Stats");
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine("Correct Words: {0}", stats.Correct);
    Console.WriteLine("Missed Words: {0}", stats.Missed);
    Console.WriteLine("Elapsed Time: {0}", elapsedTime.ToString());
    Console.WriteLine("Calculated WPM: {0}", wordsPerMinute.ToString());




}