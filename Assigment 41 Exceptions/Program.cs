using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Channels;

public class program

{

    public static List<int> parseNumbersFormString(string input)
    {

        List<int> numbers = new List<int>();
        string[] numberString = input.Split(' ');

        foreach (string numString in numberstring)
        {
            try

            {
                int num = int.Parse(numstring);
                numbers.Add(num);

            }

            catch (FormatException)
            {
                Console.WriteLine("Entry discarded");
            }

        }

        numbers.Sort((a, b) => b.CompareTo(a)); // Sort in descending order 
        return numbers;

    }

    public class WordsDTO
    {
        public string[] words { get; set; }
        public bool IsSuccess { get; set; }
        public string StatusMessage { get; set; }

    }

    public static WordsDTO ReadwordsFormaFile(string filepath)
    {
        WordsDTO dto = new WordsDTO();


        try
        {
            string fileText = File.ReadAllText(filepath);
            string[] words = fileText.Split(',');

            dto.words = words;
            dto.IsSuccess = true;
            dto.StatusMessage = "Success";

        }
        catch (FileNotFoundException)


        {
            dto.IsSuccess = false;
            dto.StatusMessage = "File not found";

        }
        catch (Exception e)
        {
            dto.IsSuccess = false;
            dto.StatusMessage = e.Message;

        }

        return dto;
    }

    public static void Main(string[] args)
    {
        //First step 
        string inputstring = "10 20 abc 30 40";
        List<int> numbers = parseNumbersFormString(inputString);

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Second step 
        string filepath = "sample.txt"; // provide the path to your file 
        WordsDTO dto = ReadwordsFormaFile(filepath);

        Console.WriteLine("Words:");
    }

    Console.WriteLine("IsSuccess: " + dto.IsSuccess);
        Console.WriteLine("Status Message: " + dto.StatusMessage);

        }
    }




