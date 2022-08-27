using System;

namespace ConsoleApp {
    public class Rectangle : Shape {
        // Rectangle properties
        private double length; 
        private double width; 

        // Constructor (Empty & Full) based on Shape(abstract) 
        public Rectangle() { }
        public Rectangle(string name, string hexColor, bool isFilled, double length, double width) : base(name, hexColor, isFilled) {
            this.name = name; 
            this.length = length; 
            this.width = width; 
        }

        //Properties
        /*
        public double Length {
            get { return length; }
            set {
                if(value <= 0) 
                    length = 1; 
                else 
                    length = value;
            }
        }
        public double Width {
            get { return Width; }
            set {
                if(value <= 0) 
                    Width = 1; 
                else 
                    Width = value;
            }
        }
        */

        /* Method(s) */ 
        // Abstract
        public override double calcPerimeter() {
            return checkSquare(length, width) ? length * 4 : (length + width) / 2; 
        }
        public override double calcArea() {
            return checkSquare(length, width) ? Math.Pow(length, 2) : length * width; 
        }
        // Normal  
        public static bool checkSquare(double length, double width) {
            return length == width;
        }
        public override string toString() {
            return $"{base.toString()}, Size(w x l): {length} x {width}, isSquare = {checkSquare(length, width)}, Perimeter = {calcPerimeter()}, Area = {calcArea()}]";
        }
    }
}