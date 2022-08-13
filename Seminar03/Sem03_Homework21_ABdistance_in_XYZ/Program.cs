//Task: XYZ coordinates are entered through the console for points A and B. The output is the distance between A and B in XYZ coordinate system.

Console.WriteLine("Enter A coordinates: ");
int ax = Convert.ToInt32(Console.ReadLine());
int ay = Convert.ToInt32(Console.ReadLine());
int az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter B coordinates: ");
int bx = Convert.ToInt32(Console.ReadLine());
int by = Convert.ToInt32(Console.ReadLine());
int bz = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(ax-bx);
// Console.WriteLine(ay-by);
// Console.WriteLine(az-bz);

double AB = Math.Sqrt(Math.Pow(ax-bx,2) + Math.Pow(ay-by,2) + Math.Pow(az-bz,2));

Console.WriteLine(AB);
