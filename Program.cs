// See https://aka.ms/new-console-template for more information
class Program
{
    public void check(int num, int[] x_used) {

    }


    static void Main(string[] args) {

        Program pr = new Program();
        string[] x_and_o = {" ", " ", " ", " ", " ", " ", " ", " ", " "};
        string[] numbers = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};

        string x_turn = "X's turn to choose a square:";
        string o_turn = "O's turn to choose a square:";

        int[] x_used = {};
        int[] o_used = {};
        int[] both_used = {};

        bool x_win = false;
        bool o_win = false;
        bool no_win = false;

        while (x_win == false && o_win == false && no_win == false) {
            Console.WriteLine("\nPlaying Board\tReference Board\n");
            Console.WriteLine($"  {x_and_o[0]} | {x_and_o[1]} | {x_and_o[2]} \t   {numbers[0]} | {numbers[1]} | {numbers[2]}\n ---|---|--- \t  ---|---|---\n  {x_and_o[3]} | {x_and_o[4]} | {x_and_o[5]} \t   {numbers[3]} | {numbers[4]} | {numbers[5]}");
            Console.WriteLine($" ---|---|--- \t  ---|---|---\n  {x_and_o[6]} | {x_and_o[7]} | {x_and_o[8]} \t   {numbers[6]} | {numbers[7]} | {numbers[8]}");
            Console.Write($"\n{x_turn} ");

            int x_move = Convert.ToInt32(Console.ReadLine());
            int x_space_chosen = x_move - 1;

            x_and_o[x_space_chosen] = "X";
            numbers[x_space_chosen] = "/";

            x_used = x_used.Append(x_move).ToArray();
            Array.Sort(x_used);
            int first_x = x_used[0];

            both_used = both_used.Append(x_move).ToArray();
            Array.Sort(both_used);
            int last = both_used[both_used.Length-1];

            if (last == 9) {
                no_win = true;
            }

            Console.WriteLine("\n\n\n");

            foreach (int i in x_used) {
                int num = i + 1;
                if (first_x + 1 == num){
//                    pr.check(num, x_used);
                    foreach (int num2 in x_used){
                        if (first_x + 2 == num2) {
                            x_win = true;
                        }
                    }
                } 
                else if (first_x + 3 == num){
                    foreach (int num2 in x_used){
                        if (first_x + 6 == num2) {
                            x_win = true;
                        }
                    }
                } 
                else if (first_x + 4 == num) {
                    foreach (int num2 in x_used){
                        if (first_x + 8 == num2) {
                            x_win = true;
                        }
                    }
                }
            }

            if (x_win == false && o_win == false && no_win == false) {
                Console.WriteLine("\nPlaying Board\tReference Board\n");
                Console.WriteLine($"  {x_and_o[0]} | {x_and_o[1]} | {x_and_o[2]} \t   {numbers[0]} | {numbers[1]} | {numbers[2]}\n ---|---|--- \t  ---|---|---\n  {x_and_o[3]} | {x_and_o[4]} | {x_and_o[5]} \t   {numbers[3]} | {numbers[4]} | {numbers[5]}");
                Console.WriteLine($" ---|---|--- \t  ---|---|---\n  {x_and_o[6]} | {x_and_o[7]} | {x_and_o[8]} \t   {numbers[6]} | {numbers[7]} | {numbers[8]}");
                Console.Write($"\n{o_turn} ");

                int o_move = Convert.ToInt32(Console.ReadLine());
                int o_space_chosen = o_move - 1;

                x_and_o[o_space_chosen] = "O";
                numbers[o_space_chosen] = "/";

                o_used = o_used.Append(o_move).ToArray();
                Array.Sort(o_used);
                int first_o = o_used[0];

                both_used = both_used.Append(x_move).ToArray();
                Array.Sort(both_used);

                Console.WriteLine("\n\n\n");

                foreach (int i in o_used) {
                    int num = i + 1;
                    if (first_o + 1 == num){
                        foreach (int num2 in o_used){
                            if (first_o + 2 == num2) {
                                o_win = true;
                            }
                        }
                    } 
                    else if (first_o + 3 == num){
                        foreach (int num2 in o_used){
                            if (first_o + 6 == num2) {
                                o_win = true;
                            }
                        }
                    } 
                    else if (first_o + 4 == num) {
                        foreach (int num2 in o_used){
                            if (first_o + 8 == num2) {
                                o_win = true;
                            }
                        }
                    }
                }
        }   }
    }   
}   