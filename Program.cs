// See https://aka.ms/new-console-template for more information
class Program {

    static void Main(string[] args) {

        Program pr = new Program();
        string[] x_and_o = {" ", " ", " ", " ", " ", " ", " ", " ", " "};
        string[] numbers = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};

        string x_turn = "X's turn: ";
        string o_turn = "O's turn: ";

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

            int sum = x_used.Length + o_used.Length;

            if (sum == 9) {
                no_win = true;
            }

            Console.WriteLine("\n\n\n");

            foreach (int num_x in x_used) {
                if (num_x == 1){
                    foreach (int num2_x in x_used){ 
                        foreach (int num3_x in x_used){
                            if ((num_x + 1 == num2_x && num2_x + 1 == num3_x) || (num_x + 3 == num2_x && num2_x + 3 == num3_x) || (num_x + 4 == num2_x && num2_x + 4 == num3_x)) {
                                x_win = true;
                            }
                        }
                    }                    
                }
                else if (num_x == 3){
                    foreach (int num2_x in x_used){ 
                        foreach (int num3_x in x_used){
                            if ((num_x + 2 == num2_x && num2_x + 2 == num3_x) || (num_x + 3 == num2_x && num2_x + 3 == num3_x)) {
                                x_win = true;
                            }
                        }
                    }                    
                }
                else if (num_x == 4 || num_x == 7){
                    foreach (int num2_x in x_used){ 
                        foreach (int num3_x in x_used){
                            if (num_x + 1 == num2_x && num2_x + 1 == num3_x) {
                                x_win = true;
                            }
                        }              
            
                    }
                }
                else if (num_x == 2){
                    foreach (int num2_x in x_used){ 
                        foreach (int num3_x in x_used){
                            if (num_x + 3 == num2_x && num2_x + 3 == num3_x) {
                                x_win = true;
                            }
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

                Console.WriteLine("\n\n\n");

                foreach (int num_o in o_used) {
                    if (num_o == 1){
                        foreach (int num2_o in o_used){ 
                            foreach (int num3_o in o_used){
                                if ((num_o + 1 == num2_o && num2_o + 1 == num3_o) || (num_o + 3 == num2_o && num2_o + 3 == num3_o) || (num_o + 4 == num2_o && num2_o + 4 == num3_o)) {
                                    o_win = true;
                                }
                            }
                        }                    
                    }
                    else if (num_o == 3){
                        foreach (int num2_o in o_used){ 
                            foreach (int num3_o in o_used){
                                if ((num_o + 2 == num2_o && num2_o + 2 == num3_o) || (num_o + 3 == num2_o && num2_o + 3 == num3_o)) {
                                    o_win = true;
                                }
                            }
                        }                    
                    }
                    else if (num_o == 4 || num_o == 7){
                        foreach (int num2_o in o_used){ 
                            foreach (int num3_o in o_used){
                                if (num_o + 1 == num2_o && num2_o + 1 == num3_o) {
                                    o_win = true;
                                }
                            }              
                
                        }
                    }
                    else if (num_o == 2){
                        foreach (int num2_o in o_used){ 
                            foreach (int num3_o in o_used){
                                if (num_o + 3 == num2_o && num2_o + 3 == num3_o) {
                                    o_win = true;
                                }
                            }
                
                        }
                    }
                }
            }
        }
            Console.WriteLine("\nPlaying Board\tReference Board\n");
            Console.WriteLine($"  {x_and_o[0]} | {x_and_o[1]} | {x_and_o[2]} \t   {numbers[0]} | {numbers[1]} | {numbers[2]}\n ---|---|--- \t  ---|---|---\n  {x_and_o[3]} | {x_and_o[4]} | {x_and_o[5]} \t   {numbers[3]} | {numbers[4]} | {numbers[5]}");
            Console.WriteLine($" ---|---|--- \t  ---|---|---\n  {x_and_o[6]} | {x_and_o[7]} | {x_and_o[8]} \t   {numbers[6]} | {numbers[7]} | {numbers[8]}");

            if (x_win == true) {
                Console.WriteLine("\n            X wins!\n");
            }
            else if (o_win == true) {
                Console.WriteLine("\n            O wins!\n");
            }
            else if (no_win == true) {
                Console.WriteLine("\n  Draw, everyone is a winner!\n");
            }
    }     
}