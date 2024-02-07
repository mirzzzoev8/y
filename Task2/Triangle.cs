namespace Task2;

public static class Triangle
{
    public static double Base { get; set; }
    public static double Height { get; set; }
    public static double CalcTriangleArea(double Base, double height){
        return 0.5 * Base * Height;
    }
    public static double CalcTrianglePerimeter(double s1, double s2, double s3){
        return s1 + s2 + s3;
    }
}
