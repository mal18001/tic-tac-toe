// See https://aka.ms/new-console-template for more information
class Program {
    static void Main(string[] args) {
        
        string[] x_and_o = {" ", " ", " ", " ", " ", " ", " ", " ", " "};
        string[] numbers = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};

        int[] x_used = {};
        int[] o_used = {};

        int adding = 0;

        bool x_win = false;
        bool o_win = false;
        bool no_win = false;

        bool loop_x(int adding, int num_x) {
            foreach (int num2_x in x_used){ 
                foreach (int num3_x in x_used){
                    if ((num_x + (adding) == num2_x && num2_x + (adding) == num3_x)) {
                        x_win = true;
                        
                    
                        
                    }
                }
            }
            return true;
        }
        bool loop_o(int adding, int num_o) {
            foreach (int num2_o in o_used){ 
                foreach (int num3_o in o_used){
                    if ((num_o + (adding) == num2_o && num2_o + (adding) == num3_o)) {
                        o_win = true;
                            

                    }
                }
            }
            return true;
        }

        while (x_win == false && o_win == false && no_win == false) {

            Console.WriteLine($"\nPlaying Board\tReference Board\n\n  {x_and_o[0]} | {x_and_o[1]} | {x_and_o[2]} \t   {numbers[0]} | {numbers[1]} | {numbers[2]}\n ---|---|--- \t  ---|---|---\n  {x_and_o[3]} | {x_and_o[4]} | {x_and_o[5]} \t   {numbers[3]} | {numbers[4]} | {numbers[5]}\n ---|---|--- \t  ---|---|---\n  {x_and_o[6]} | {x_and_o[7]} | {x_and_o[8]} \t   {numbers[6]} | {numbers[7]} | {numbers[8]}");
            Console.Write("\nX's turn: ");

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
                    adding = 1;
                    loop_x(adding, num_x);
                    adding = 3;
                    loop_x(adding, num_x);
                    adding = 4;
                    loop_x(adding, num_x);                  
                }
                else if (num_x == 4 || num_x == 7){
                    adding = 1;
                    loop_x(adding, num_x);
                }
                else if (num_x == 3){
                    adding = 2;
                    loop_x(adding, num_x);
                    adding = 3;
                    loop_x(adding, num_x);                 
                }
                else if (num_x == 2){
                    adding = 3;
                    loop_x(adding, num_x);
                }
            }
            if (x_win == false && o_win == false && no_win == false) {

                Console.WriteLine($"\nPlaying Board\tReference Board\n\n  {x_and_o[0]} | {x_and_o[1]} | {x_and_o[2]} \t   {numbers[0]} | {numbers[1]} | {numbers[2]}\n ---|---|--- \t  ---|---|---\n  {x_and_o[3]} | {x_and_o[4]} | {x_and_o[5]} \t   {numbers[3]} | {numbers[4]} | {numbers[5]}\n ---|---|--- \t  ---|---|---\n  {x_and_o[6]} | {x_and_o[7]} | {x_and_o[8]} \t   {numbers[6]} | {numbers[7]} | {numbers[8]}");
                Console.Write("\nO's turn: ");

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
                        adding = 1;
                        loop_o(adding, num_o);
                        adding = 3;
                        loop_o(adding, num_o);
                        adding = 4;
                        loop_o(adding, num_o);                  
                    }
                    else if (num_o == 4 || num_o == 7){
                        adding = 1;
                        loop_o(adding, num_o);
                    }
                    else if (num_o == 3){
                        adding = 2;
                        loop_o(adding, num_o);
                        adding = 3;
                        loop_o(adding, num_o);                 
                    }
                    else if (num_o == 2){
                        adding = 3;
                        loop_o(adding, num_o);
                    }
            }   
            }
        }
        Console.WriteLine($"\nPlaying Board\tReference Board\n\n  {x_and_o[0]} | {x_and_o[1]} | {x_and_o[2]} \t   {numbers[0]} | {numbers[1]} | {numbers[2]}\n ---|---|--- \t  ---|---|---\n  {x_and_o[3]} | {x_and_o[4]} | {x_and_o[5]} \t   {numbers[3]} | {numbers[4]} | {numbers[5]}\n ---|---|--- \t  ---|---|---\n  {x_and_o[6]} | {x_and_o[7]} | {x_and_o[8]} \t   {numbers[6]} | {numbers[7]} | {numbers[8]}");
        if (x_win == true) {
            Console.WriteLine("\n            X won!\n");
        }
        else if (o_win == true) {
            Console.WriteLine("\n            O won!\n");
        }
        else if (no_win == true) {
            Console.WriteLine("\n  Draw, everyone is a winner!\n");
        }
    }   
}