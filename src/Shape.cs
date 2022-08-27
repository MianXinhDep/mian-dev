namespace ConsoleApp {
    public abstract class Shape {
        // Properties -> Protected
        protected string name; 
        protected string hexColor; 
        protected bool isFilled;

        // Constructor (Empty & Full)
        public Shape() { }
        public Shape(string name, string hexColor, bool isFilled) {
            this.name = name;
            this.hexColor = hexColor; 
            this.isFilled = isFilled; 
        }

        /* Method(s) */
        // Normal 
        public virtual string toString() {
            return $"Shape[[Name: {name}, Color: {hexColor}, Filled: {isFilled}]";
        }
        // Abstract
        public abstract double calcPerimeter();
        public abstract double calcArea();
    }
}