using System;
class Line{
    public double x1,y1,x2,y2;

    public Line(double x1, double y1, double x2, double y2){
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;

    }
    public double length(){
        return Math.Sqrt(Math.Pow(x2-x1, 2) +Math.Pow(y2-y1, 2));
    }

    public static void Main(){
        Console.WriteLine("Welcome to Line Comparisom Computation Program");
        Line line = new Line(0,0,1,1);
        Console.WriteLine("Length of the line is: " + line.length());
    }
}