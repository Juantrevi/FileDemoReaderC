
try
{
    const string fileName = @"C:\Users\juant\OneDrive\Escritorio\Dorset\7 - OOP\FileDemo\FileDemoReader\sample.txt";
    var reader = new StreamReader(fileName);
    while (!reader.EndOfStream)
    {
        var line = reader.ReadLine();
        Console.WriteLine(line);
    }

    reader.Close();
    Console.ReadLine();
}
catch (Exception e)
{
    Console.WriteLine("Failed:" + e.Message);
}
finally
{
    Console.WriteLine("Finally block");
}