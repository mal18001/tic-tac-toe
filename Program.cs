// See https://aka.ms/new-console-template for more information
string[] numbers = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};

// bool first = true;
// bool second = true;
// bool third = true;
// bool fourth = true;
// bool fifth = true;
// bool sixth = true;
// bool seventh = true;
// bool eighth = true;
// bool ninth = true;

// string board1 = "     |     |";
// string board2 = "  1  |  2  |  3";
// string board3 = "-----|-----|-----";
// string board4 = "  4  |  5  |  6";
// string board5 = "-----|-----|-----";
// string board6 = "  7  |  8  |  9";
// string board7 = "     |     |";

string x_turn = "X's turn to choose a square:";
string o_turn = "O's turn to choose a square:";

bool win = false;

while (win == false) {
    Console.WriteLine($"\n {numbers[0]} | {numbers[1]} | {numbers[2]} \n---|---|---\n {numbers[3]} | {numbers[4]} | {numbers[5]} \n---|---|---\n {numbers[6]} | {numbers[7]} | {numbers[8]}");
    Console.Write($"\n{x_turn} ");
    int x_move = Console.ReadLine();
    int x_space_chosen = x_move - 1;
    numbers[x_space_chosen] = "X";
    int i = 0;
    foreach (string number in numbers) {
        List<int> check = new List<int>();
        i++;
        if (number == "X") {
            check.Add(i);
        }
    }

    }
    
    while (win == false) {
        Console.WriteLine($"\n {numbers[0]} | {numbers[1]} | {numbers[2]} \n---|---|---\n {numbers[3]} | {numbers[4]} | {numbers[5]} \n---|---|---\n {numbers[6]} | {numbers[7]} | {numbers[8]}");
        Console.Write($"\n{o_turn} ");
        int o_move = Console.ReadLine();
        int o_space_chosen = x_move - 1;
        numbers[o_space_chosen] = "O";
    }

}