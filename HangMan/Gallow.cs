namespace HangMan
{    
    public class Gallow
    {
        private string[][] _stages =
        {
            // start stage
           ["  +---+  ",
            "  |   |  ",
            "      |  ",
            "      |  ",
            "      |  ",
            "      |  ",
            "========="],

           // 1 mistake stage
           ["  +---+  ",
            "  |   |  ",
            "  O   |  ",
            "      |  ",
            "      |  ",
            "      |  ",
            "========="],

           // 2 mistake stage and etc...
           ["  +---+  ",
            "  |   |  ",
            "  O   |  ",
            "  |   |  ",
            "      |  ",
            "      |  ",
            "========="],

           ["  +---+  ",
            "  |   |  ",
            "  O   |  ",
            " /|   |  ",
            "      |  ",
            "      |  ",
            "========="],

           ["  +---+  ",
            "  |   |  ",
            "  O   |  ",
            " /|\\  |  ",
            "      |  ",
            "      |  ",
            "========="],

           ["  +---+  ",
            "  |   |  ",
            "  O   |  ",
            " /|\\  |  ",
            " /    |  ",
            "      |  ",
            "========="],

           ["  +---+  ",
            "  |   |  ",
            "  O   |  ",
            " /|\\  |  ",
            " / \\  |  ",
            "      |  ",
            "========="],
        };
        public void DisplayGallow(int countOfMistakes)
        {         
            foreach (var line in _stages[countOfMistakes])
            {
                Console.WriteLine(line);
            }
        }
    }
}
