using System;
using System.Linq;
using System.Text;

namespace StringPlay
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string testletters = "ABCdefGhIjKlmnopqRStUVwxyz";
            string testSentence = "How now brown cow.";
            Console.Write("Please enter some text: ");
            input = Console.ReadLine();
            
            //Challenge 23 Display first 10 chars
            Console.WriteLine($"The first 10 charaters are: {testletters.Substring(0, 10)}");
            //Challenge 24 Display last 10 chars
            Console.WriteLine($"The last 10 charaters are: {testletters.Substring(testletters.Length - 10, 10)}");

            //Challenge 25 Break out the words in a sentence and display them on different lines
            string SubsituteSentence = testSentence;
            int Length = SubsituteSentence.Length;
            int word = SubsituteSentence.IndexOf(" ");
            for (int i = word; i > 0;)
            {
                Console.WriteLine(SubsituteSentence.Substring(0, word));
                word++;
                Length = Length - word;
                SubsituteSentence = SubsituteSentence.Substring(word, Length);
//                Console.WriteLine(SubsituteSentence);
                word = SubsituteSentence.IndexOf(" ");
                i = word;
//                Console.WriteLine($"word = {word} Length = {Length}");
            }
            Console.WriteLine(SubsituteSentence);

            //Challenge 26 How many Vowels?
            //Challenge 27 How many consonants?
            int vowelCount = 0;
            int consoCount = 0;
            Length = 0;
            for (int i = 0; i < testSentence.Length; i++)
            {
                char letter = testSentence[i];
//                Console.WriteLine(letter);
                if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter =='U' || letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    vowelCount++;
                }
                if (letter != ' ')
                {
                    Length++;
                }
            }
            consoCount = Length - vowelCount;
            Console.WriteLine($"The number of Vowels is: {vowelCount}");
            Console.WriteLine($"The number of Vowels is: {consoCount}");

            // String Comparision
            // String comparision is more than meets the eye

            string word1 = "Test";
            string word2 = "TEST";

            if (word1 != word2)
            {
                Console.WriteLine($"When using a basic == operator {word1} and {word2} are not equal");
            }

            if (String.Equals(word1, word2, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine($"When using the StringComparison.CurrentCultureIgnoreCase {word1} and {word2} are the same" );
            }

            Console.WriteLine();

            //String sorting!
            int count = 0;
            string[] names = {"Jeffrey", "David", "Adam", "Brendan", "Aaron", "Dave", "Eric", "Zach", "Tiia", "Tyler", "Rick", "Manny", "Kathryn", "Eugene", "Jim" };
            int m = 0;
            for(int k = 0; k < names.Count(); k++)
            {
                Console.Write($"{names[k]}, ");
            }
            Console.WriteLine();
            do
            {
                
                for (int j = 0; j < names.Count()-1; j++)
                {
                    if (string.Compare(names[j], names[j+1]) == 1)
                    {
                        m++;
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                    else
                    {
                        m--;
                    }
                    count++;
                    Console.Write($"{count} ");
                }
            } while (m < names.Count());
            Console.WriteLine();
            foreach (string entry in names)
            {
                Console.Write($"{entry}, ");
            }
            Console.WriteLine();

            //String Builder

            StringBuilder builder = new StringBuilder();
            builder.Append("Hello ");
            builder.Append("World");

            builder.Insert(6, "there ");
            string mystring = builder.ToString();
            Console.WriteLine(mystring);

            Console.WriteLine("{0} chars: {1}", builder.Length, builder.ToString());

            // Made up challenge... return a substring up to a space
            string MyName = "David Christopher Heizer";
            Console.WriteLine("My name is " + MyName);
            Console.WriteLine($"My first name is {MyName.Substring(0,MyName.IndexOf(' '))}");


        }
    }
}
