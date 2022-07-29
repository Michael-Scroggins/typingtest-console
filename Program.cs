using System.Diagnostics;
using System.Text;
using System.Linq;
using TypingGame;


string[] words;

string path = @"C:\Users\Public\words.txt";

List<string> wordsList = new List<string>();


if (File.Exists(path))
{

    string[] lines = File.ReadAllLines(path);

    foreach (string line in lines)
    {
        wordsList.Add(line);
 
    }


    words = wordsList.ToArray();
}

else {

    words = new string[3];

    words[0] = "Dog";
    words[1] = "Cat";
    words[2] = "Horse";

}



var stopWatch = new Stopwatch();
Random random = new Random();

Stats stats = new Stats();


Console.WriteLine("Do you want to start the test? (Y/N)");

string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
string? input = Console.ReadLine();
string? gameDecision = input.ToUpper();




string word;


while (gameDecision != "N") // #1 Master Loop

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



        for (int i = 0; i < numberOfWordsToType; i++)
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


    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Log.txt"), true)) 
    {
        outputFile.WriteLine(DateTime.Now.ToString());
        outputFile.WriteLine("===============");
        outputFile.WriteLine("Correct Words: {0}", stats.Correct);
        outputFile.WriteLine("Missed Words: {0}", stats.Missed);
        outputFile.WriteLine("Elapsed Time: {0}", elapsedTime.ToString());
        outputFile.WriteLine("Calculated WPM: {0}", wordsPerMinute.ToString());
        outputFile.WriteLine("===============");
        outputFile.WriteLine("");


    }

}

