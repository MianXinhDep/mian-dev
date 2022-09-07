using System; 
using System.Text; 

namespace ConsoleApp {
    public class Program {
        // Define a bool function 
        internal static bool rtnFilled(int chkInt) {
            return chkInt == 0 ? false : true; 
        }
        public static Rectangle generateRectangle() {
            // Declare new Rectangle object
            Console.Write("Enter new rectangle's name: "); 
            string name = Console.ReadLine(); 
            Console.Write("Enter color code(hex): ");

            string hexColor = Console.ReadLine(); 
            // Check by int to switch case -> bool
            Console.Write("Is this new shape filled? (1/0): "); 
            int chkFilled = int.Parse(Console.ReadLine()); 
            bool isFilled = rtnFilled(chkFilled); 
            /*
            switch(chkFilled) {
                case 0: 
                    isFilled = false; 
                    break;  
                default: 
                    isFilled = true;
                    break; 
            }
            */

            // Get Rectangle's w x l 
            Console.Write("Enter new shape's length: "); 
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter new shape's width: ");
            double width = double.Parse(Console.ReadLine());

            Rectangle R1 = new Rectangle(name, hexColor, isFilled, length, width); 
            return R1; 
        }
        internal static void Main(string[] args) {
            /* I/O Unicode Standard */
            Console.InputEncoding  = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            /* Main program here! */
            int cont = 1;
            while(cont == 1) {
                Console.WriteLine();
                Rectangle R1 = generateRectangle();
                Console.WriteLine(); 
                Console.WriteLine(R1.toString());
                Console.WriteLine(); 
                Console.Write("\tContinue? (1/0): ");
                cont = int.Parse(Console.ReadLine());
            }
        }
    }
}