// See https://aka.ms/new-console-template for more information
class Program
{
    public void check(int num, int[] x_used) {

    }


    static void Main(string[] args) {

        Program pr = new Program();
        string[] numbers = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};

        string x_turn = "X's turn to choose a square:";
        string o_turn = "O's turn to choose a square:";

        int[] x_used = {};
        int[] o_used = {};
        int[] both_used = {};

        bool x_win = false;
        bool o_win = false;

        while (x_win == false && o_win == false) {
            Console.WriteLine($"\n {numbers[0]} | {numbers[1]} | {numbers[2]} \n---|---|---\n {numbers[3]} | {numbers[4]} | {numbers[5]} \n---|---|---\n {numbers[6]} | {numbers[7]} | {numbers[8]}");
            Console.Write($"\n{x_turn} ");

            int x_move = Convert.ToInt32(Console.ReadLine());
            int x_space_chosen = x_move - 1;

            numbers[x_space_chosen] = "X";

            x_used = x_used.Append(x_move).ToArray();
            Array.Sort(x_used);
            int first_x = x_used[0];

            foreach (int num in x_used) {
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
                        if (first_x + 2 == num2) {
                            x_win = true;
                        }
                    }
                } 
                else if (first_x + 4 == num) {
                    foreach (int num2 in x_used){
                        if (first_x + 2 == num2) {
                            x_win = true;
                        }
                    }
                }
            }
        }

            while (x_win == false && o_win == false) {
                Console.WriteLine($"\n {numbers[0]} | {numbers[1]} | {numbers[2]} \n---|---|---\n {numbers[3]} | {numbers[4]} | {numbers[5]} \n---|---|---\n {numbers[6]} | {numbers[7]} | {numbers[8]}");
                Console.Write($"\n{o_turn} ");

                int o_move = Convert.ToInt32(Console.ReadLine());
                int o_space_chosen = o_move - 1;

                numbers[o_space_chosen] = "O";

                o_used = o_used.Append(o_move).ToArray();
                Array.Sort(o_used);
                int first_o = o_used[0];

                foreach (int num in o_used) {
                    if (first_o + 1 == num){
//                        pr.check(num, o_used);
                        foreach (int num2 in o_used){
                            if (first_o + 2 == num2) {
                                o_win = true;
                            }
                        }
                    } 
                    else if (first_o + 3 == num){
                        foreach (int num2 in o_used){
                            if (first_o + 2 == num2) {
                                o_win = true;
                            }
                        }
                    } 
                    else if (first_o + 4 == num) {
                        foreach (int num2 in o_used){
                            if (first_o + 2 == num2) {
                                o_win = true;
                            }
                        }
                    }
                }
            }
    }   
}   