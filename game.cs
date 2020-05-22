using System;
using System.Collections.Generic;
using System.Text;

namespace XO
{
    class game
    {
        private string n1 = " ";
        private string n2 = " ";
        private string n3 = " ";
        private string n4 = " ";
        private string n5 = " ";
        private string n6 = " ";
        private string n7 = " ";
        private string n8 = " ";
        private string n9 = " ";
        public void dislay_game()
        {
            Console.WriteLine(" " + n7 + " | " + n8 + " | " + n9);
            Console.WriteLine(" ---------");
            Console.WriteLine(" " + n4 + " | " + n5 + " | " + n6);
            Console.WriteLine(" ---------"); 
            Console.WriteLine(" " + n1 + " | " + n2 + " | " + n3);
        }

        public bool checkwinner()
        {
            if (n7 == "X" & n8 == "X" & n9 == "X")
            {
                return false;
            }
            else if (n7 == "X" & n4 == "X" & n1 == "X")
            {
                return false;
            }
            else if (n8 == "X" & n5 == "X" & n2 == "X")
            {
                return false;
            }
            else if (n9 == "X" & n6 == "X" & n3 == "X")
            {
                return false;
            }
            else if (n7 == "X" & n5 == "X" & n3 == "X")
            {
                return false;
            }
            else if (n9 == "X" & n5 == "X" & n1 == "X")
            {
                return false;
            }
            else if (n4 == "X" & n5 == "X" & n6 == "X")
            {
                return false;
            }
            else if (n1 == "X" & n2 == "X" & n3 == "X")
            {
                return false;
            }
            else return true;
        }

        public bool checkwinner2()
        {
            if (n7 == "O" & n8 == "O" & n9 == "O")
            {
                return false;
            }
            else if (n7 == "O" & n4 == "O" & n1 == "O")
            {
                return false;
            }
            else if (n8 == "O" & n5 == "O" & n2 == "O")
            {
                return false;
            }
            else if (n9 == "O" & n6 == "O" & n3 == "O")
            {
                return false;
            }
            else if (n7 == "O" & n5 == "O" & n3 == "O")
            {
                return false;
            }
            else if (n9 == "O" & n5 == "O" & n1 == "O")
            {
                return false;
            }
            else if (n4 == "O" & n5 == "O" & n6 == "O")
            {
                return false;
            }
            else if (n1 == "O" & n2 == "O" & n3 == "O")
            {
                return false;
            }
            else return true;
        }

        public void set_num_p1(string num_p1)
        {
            if (num_p1 == "1" & n1 == " ")
            {
                this.n1 = "X";
            }
            else if (num_p1 == "2" & n2 == " ")
            {
                this.n2 = "X";
            }
            else if (num_p1 == "3" & n3 == " ")
            {
                this.n3 = "X";
            }
            else if (num_p1 == "4" & n4 == " ")
            {
                this.n4 = "X";
            }
            else if (num_p1 == "5" & n5 == " ")
            {
                this.n5 = "X";
            }
            else if (num_p1 == "6" & n6 == " ")
            {
                this.n6 = "X";
            }
            else if (num_p1 == "7" & n7 == " ")
            {
                this.n7 = "X";
            }
            else if (num_p1 == "8" & n8 == " ")
            {
                this.n8 = "X";
            }
            else if (num_p1 == "9" & n9 == " ")
            {
                this.n9 = "X";
            }

        }
        public void set_num_p2(string num_p2)
        {
            if (num_p2 == "1" & n1 == " ")
            {
                this.n1 = "O";
            }
            else if (num_p2 == "2" & n2 == " ")
            {
                this.n2 = "O";
            }
            else if (num_p2 == "3" & n3 == " ")
            {
                this.n3 = "O";
            }
            else if (num_p2 == "4" & n4 == " ")
            {
                this.n4 = "O";
            }
            else if (num_p2 == "5" & n5 == " ")
            {
                this.n5 = "O";
            }
            else if (num_p2 == "6" & n6 == " ")
            {
                this.n6 = "O";
            }
            else if (num_p2 == "7" & n7 == " ")
            {
                this.n7 = "O";
            }
            else if (num_p2 == "8" & n8 == " ")
            {
                this.n8 = "O";
            }
            else if (num_p2 == "9" & n9 == " ")
            {
                this.n9 = "O";
            }
        }

        

       

    }
}
