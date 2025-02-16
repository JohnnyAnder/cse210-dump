using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    static ScriptureToMemorize mySTM1
    ;
    static void Main(string[] args)
    {
        //All the test code

        // Word myWord = new Word("Behold");
        // myWord.Display(); Console.WriteLine();
        // myWord.Hide();
        // myWord.Display(); Console.WriteLine();
        //
        // Verse myVerse = new Verse("Behold, there are many called, few are chosen. And why are they not chosen?");
        // myVerse.Display(); Console.WriteLine();
        // for (int i=4; i<=12; i+=4)
        // {
        //     myVerse.HideWord(i);
        //     myVerse.Display(); Console.WriteLine();
        // }
        //
        // ScriptureCitation myCitation1 = new ScriptureCitation("D&C",121, 34);
        // ScriptureCitation myCitation2 = new ScriptureCitation("D&C", 121, 34, 36);
        // myCitation1.Display(); Console.WriteLine();
        // myCitation2.Display(); Console.WriteLine();
        //

        //add scriptures
        AddScriptures();

        //clear console and choose a scripture
        Console.Clear();
        ScriptureToMemorize scripture = ChooseScripture();

        //clear console and display scripture
        Console.Clear();
        scripture.Display();

        // loop to hide words
       
        string input = "";
        while (input != "quit")
        {
            Console.Write("Press 'ENTER' when ready, or type 'quit' to exit. ");
            input = Console.ReadLine();
            if (input == "")
            {
                Console.Clear();
                Program.mySTM1.HideThreeWords();
                Program.mySTM1.Display();
                Console.WriteLine($"Number of words still to memorize: {Program.mySTM1.GetTotalRevealedWords()}");
            }
            if (Program.mySTM1.GetTotalRevealedWords() == 0)
            {
                Console.WriteLine("You memorized it all! Have a great day!");
                input = "quit";
            }
        }
        

    }
    static ScriptureToMemorize ChooseScripture()
    {
        Console.WriteLine("Which scripture do you want to memorize? Write the number only, please. (ex. 1)");
        Console.WriteLine($"1. {mySTM1._reference}");
        string choice = Console.ReadLine();
        ScriptureToMemorize scripture = new ScriptureToMemorize();
        if (choice == "1")
        {
            scripture = mySTM1;
        } 
        return scripture;
    }
    static void AddScriptures()
    {
        //add scripture 1
        ScriptureCitation myReference1 = new ScriptureCitation("D&C", 121, 34, 36);
        Verse my1Verse34 = new Verse("Behold, many are called, but few are chosen. And why are they not chosen?");
        Verse my1Verse35 = new Verse("Because their hearts are set so much upon the things of this world, and aspire to the honors of man, that they do not learn this one lesson-");
        Verse my1Verse36 = new Verse("That the rights of the priesthood are inseparably connected with the powers pf heaven, and the powers of heaven cannot be controlled nor handled only upon the principles of righteousness");
        List<Verse> myVerseList1 = new List<Verse>();
        myVerseList1.Add(my1Verse34);
        myVerseList1.Add(my1Verse35);
        myVerseList1.Add(my1Verse36);
        ScriptureToMemorize mySTM1 = new ScriptureToMemorize(myReference1, myVerseList1);
    }
}