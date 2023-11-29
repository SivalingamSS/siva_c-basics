using System;
using System.Globalization;

class Program
{
    public void tree()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
       // int a = 12;
        string result = ReverseWords(input);
        Console.WriteLine("Updated string: " + result);
    }
    static string ReverseWords(string input)
    {
        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length >= 2)
            {
                char[] wordChars = words[i].ToCharArray();
                Array.Reverse(wordChars);
                words[i] = new string(wordChars);
            }
        }
        string result = string.Join(" ", words);

        return result;
    }
    public void flower()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int alphabetCount = 0;
        int digitCount = 0;
        int specialCharCount = 0;

        foreach (char c in input)
        {
            if (char.IsLetter(c))
                alphabetCount++;
            else if (char.IsDigit(c))
                digitCount++;
            else
                specialCharCount++;
        }
        {
            Console.WriteLine("Alphabets: " + alphabetCount);
            Console.WriteLine("Digits: " + digitCount);
            Console.WriteLine("Special Characters: " + specialCharCount);

        }
    }
    public void bulid()
    {
        string str1 = "sister";
        string str2 = "Sister";
        string relation;
        int result;
        result = String.Compare(str1, str2);
        if (result > 0)
            relation = "comes after";
        else if (result == 0)
            relation = "is the same as";
        else
            relation = "comes before";

        Console.WriteLine("'{0}' {1} '{2}'.",
                          str1, relation, str2);
        result = String.Compare(str1, str2 );
        if (result > 0)
            relation = "comes after";
        else if (result == 0)
            relation = "is the same as";
        else
            relation = "comes before";

        Console.WriteLine("'{0}' {1} '{2}'.",
                          str1, relation, str2);
        result = String.CompareOrdinal(str1, str2);
        if (result > 0)
            relation = "comes after";
        else if (result == 0)
            relation = "is the same as";
        else
            relation = "comes before";

        Console.WriteLine("'{0}' {1} '{2}'.", str1, relation, str2);

    }
   

  
    static int CountVowels(string input)
    {
        int count = 0;
        string vowels = "aeiouAEIOU";

        foreach (char ch in input)
        {
            if (vowels.Contains(ch))
            {
                count++;
            }
        }

        return count;
    }

    static int CountConsonants(string input)
    {
        int count = 0;
        string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";

        foreach (char ch in input)
        {
            if (consonants.Contains(ch))
            {
                count++;
            }
        }

        return count;
    }
    public static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int vowelCount = CountVowels(input);
        int consonantCount = CountConsonants(input);

        Console.WriteLine("Number of vowels: " + vowelCount);
        Console.WriteLine("Number of consonants: " + consonantCount);
    }
    
    public  void  word()
    {
        string str;
        int wrd, l;
        Console.Write("Input the string : ");
        str = Console.ReadLine();

        l = 0;
        wrd = 1;

        while (l <= str.Length - 1)
        {
            if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
            {
                wrd++;
            }

            l++;
        }

        Console.Write("Total number of words in the string is : {0}\n", wrd);
    }



    public static void Main(string[] args)
    {
        Program m = new Program();
        m.tree();
        m.flower();
        m.bulid();
        m.word();
    }

}
