namespace Task2;

public static class Circle
{
    public static double Radius { get; set; }
    public static double CalcCircleArea(double radius){
       return radius * radius * 3.14;
    }
     public static double CalcCirclePerimeter(double radius){
       return 2 * radius * 3.14;
    }

}
