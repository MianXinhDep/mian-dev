using System;

namespace ConsoleApp {
    public class Cylinder : Shape {
        // Rectangle properties
        private double radius;
        private double height;

        // Constructor (Empty & Full) based on Shape(abstract) 
        public Cylinder() { }
        public Cylinder(string name, string hexColor, bool isFilled, double radius, double height) : base(name, hexColor, isFilled) {
            this.name = name; 
            this.radius = radius;
            this.height = height;
        }

        //Properties
        /*
        public double Radius {
            get { return radius; }
            set {
                if(value <= 0) 
                    radius = 1; 
                else 
                    radius = value;
            }
        }
        public double Height {
            get { return height; }
            set {
                if(value <= 0) 
                    height = 1; 
                else 
                    height = value;
            }
        }
        */

        /* Method(s) */ 
        // Abstract
        public override double calcPerimeter() {
            double pi = Math.PI;
            return 2 * pi * radius * height + 2 * pi * Math.Pow(radius, 2);
        }
        public override double calcArea() {
            double pi = Math.PI; 
            return pi * Math.Pow(radius, 2) * height;
        }
        // Normal  
        public static bool checkSquare(double length, double width) {
            return length == width;
        }
        public override string toString() {
            return $"{base.toString()}, Size(r x h): {radius} x {height}, Perimeter = {calcPerimeter()}, Area = {calcArea()}]";
        }
    }
}