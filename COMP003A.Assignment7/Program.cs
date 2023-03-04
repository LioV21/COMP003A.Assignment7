/*
*  Author: Lionel Villanueva
* Course: COMP-003A
* Pupose: Basic Data Structures
*/

class Program
{
    static void Main()
    {
        // CharacterCounter Section
        Console.WriteLine("Character Counter Section");
        Console.Write("Please enter a letter: ");
        char charInput = Console.ReadLine()[0];
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        int count = CharacterCounter(charInput, word);
        Console.WriteLine($"The character '{charInput}' appears in '{word}' {count} times.");
        SectionSeparator();

        // IsPalindrome Section
        Console.WriteLine("Palindrome Section");
        Console.Write("Enter a word: ");
        string palindromeInput = Console.ReadLine();
        bool isPalindrome = IsPalindrome(palindromeInput);
        Console.WriteLine($"The word '{palindromeInput}' {(isPalindrome ? "is" : "is not")} a palindrome.");
        SectionSeparator();

        // Add Section
        Console.WriteLine("Add Section");
        List<string> names = new List<string>();
        char userInput;
        do
        {
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            names.Add(name);
            Console.Write("Press any key to add more or (e) to exit: ");
            userInput = Console.ReadKey().KeyChar;
            Console.WriteLine();
        } while (userInput != 'e');

        // Traversal Section
        Console.WriteLine("Traversal Section");
        TraverseList(names);
        SectionSeparator();

        // Reverse Traversal Section
        Console.WriteLine("Reverse Traversal Section");
        TraverseListReverse(names);
        SectionSeparator();
    }

    static int CharacterCounter(char characterInput, string word)
    {
        int count = 0;
        characterInput = char.ToLower(characterInput);
        word = word.ToLower();
        foreach (char c in word)
        {
            if (char.ToLower(c) == characterInput)
            {
                count++;
            }
        }
        return count;
    }

    static bool IsPalindrome(string word)
    {
        string reversedWord = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord += char.ToLower(word[i]);
        }
        return reversedWord == word.ToLower();
    }

    static void TraverseList(List<string> list)
    {
        Console.WriteLine("Traversing list:");
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }

    static void TraverseListReverse(List<string> list)
    {
        Console.WriteLine("Traversing list in reverse:");
        for (int i = list.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(list[i]);
        }
    }

    static void SectionSeparator(string separator = "*")
    {
        Console.WriteLine(new string(separator[0], 40));
    }
}
