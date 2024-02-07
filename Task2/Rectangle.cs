namespace Task2;

public static class Rectangle
{
    public static double Lenght { get; set; }
    public static double Width { get; set; }
    public static double CalcRectanglePerimeter(double Lenght, double Width){
       return 2*(Lenght + Width);
    }
    public static double CalcRectangleArea(double Lenght, double Width){
       return Lenght * Width;
    }
}
