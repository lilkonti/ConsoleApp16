namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numFib = "C:\\Users\\Korn_\\source\\repos\\ConsoleApp16\\FibNum.txt";

            File.Create(numFib).Dispose();

            int[] fib_int = new int[11];
            int f1 = 1; int f2 = 1;
            fib_int[0] = f1;
            fib_int[1] = f2;
            for (int i = 2; i < fib_int.Length; i++)
            {
                fib_int[i] = fib_int[i - 1] + fib_int[i - 2];
            }
            for (int i = 0; i < fib_int.Length; i++)
            {
                string text = File.ReadAllText(numFib);
                File.WriteAllText(numFib, text + Convert.ToString(fib_int[i]) + '\n');
            }

            string numSimple = "C:\\Users\\Korn_\\source\\repos\\ConsoleApp16\\SimpleNum.txt";

            File.Create(numSimple).Dispose();

            int index = 4;

            for (int i = 4; i != 100; i++)
            {

                if (i == fib_int[index])
                {
                    i++;
                    if (index == 10) index = 1;
                    ++index;
                }
                string text = File.ReadAllText(numSimple);
                File.WriteAllText(numSimple, text + Convert.ToString(i) + '\n');
            }

            Console.WriteLine("task 2");

            string word = Console.ReadLine();

            string textShemi = "hello world i learn c#";

            string textFile = "C:\\Users\\Korn_\\source\\repos\\ConsoleApp16\\textFile.txt";

            File.Create(textFile).Dispose();

            File.WriteAllText(textFile, textShemi);

            string[] Words = textShemi.Split(' ');

            for (int i = 0; i < Words.Length; i++)
            {
                if (Words[i] == word) Words[i] = "rem";
            }
            for (int i = 0; i < Words.Length; i++)
            {
                string text_buff = File.ReadAllText(textFile);
                File.WriteAllText(textFile, text_buff + Words[i] + "\n");
            }

            Console.WriteLine("task 3");

            string txtModer = "C:\\Users\\Korn_\\source\\repos\\ConsoleApp16\\txtModer.txt";

            File.Create(txtModer).Dispose();

            string textOriginal = "Mega super good hello";
            string[] textOrigSplit = textOriginal.Split(" ");
            string[] wordsModer = {"super", "good" };

            for(int i = 0; i < textOrigSplit.Length; i++)
            {
                if (textOrigSplit[i] == wordsModer[1] || textOrigSplit[i] == wordsModer[0])
                { textOrigSplit[i] = "***"; }
            }
            for (int i = 0; i < textOrigSplit.Length; i++)
            {
                string text_buff = File.ReadAllText(txtModer);
                File.WriteAllText(txtModer, text_buff + textOrigSplit[i] + "\n");
            }

            string numBig = "C:\\Users\\Korn_\\source\\repos\\ConsoleApp16\\numBig.txt";

            File.Create(numBig).Dispose();

            for (int i = -50000; i < 50000; i++)
            {
                string text_buff = File.ReadAllText(numBig);
                File.WriteAllText(numBig, text_buff + i + "\n");
            }
        }
    }
}