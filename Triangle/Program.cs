namespace Triangle;

public class AreaOfTriangle
{
    public static void Main(string[] args)
    {
        double area, 
            
         baselength,
         height;


        Console.Write("Enter the baselength of the triangle: ");
        baselength = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        height = Convert.ToDouble(Console.ReadLine());

        area = (height * baselength) / 2;
        Console.WriteLine($"The area of your triangle is: {area} ");

    }

}