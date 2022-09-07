using System; 

namespace ConsoleApp { 
    public class Circle : Shape {
        // Circle properties
        private double radius; 
        private double dimesion; 

        // Constructor (Empty & Full) based on Shape(abstract)
        public Circle() { }
        public Circle(string name, string hexColor, bool isFilled, double radius) : base(name, hexColor, isFilled) {
            this.radius = radius; 
        }

        // Properties
        public double Radius { 
            get { return radius; }
            set {
                if(value <= 0) 
                    radius = 1; 
                else 
                    radius = value;
            }
        }

        /* Method(s) */
        // Abstract
        public override double calcPerimeter() {
            return Math.Pow(radius, 2);
        }
        // Normal  

    }
}