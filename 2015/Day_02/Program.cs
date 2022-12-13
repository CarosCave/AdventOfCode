using System.Text;

string line = "";
string[] temp = new string[3];
int wrappingPaper = 0;
int ribbon = 0;

StreamReader sr = new StreamReader("201502_Input.txt", Encoding.UTF8);
line = sr.ReadLine();

try
{
    while (line != null)
    {
        temp = line.Split('x', 3);

        wrappingPaper += WrappingPaper(int.Parse(temp[0]), int.Parse(temp[1]), int.Parse(temp[2]));
        ribbon += Ribbon(int.Parse(temp[0]), int.Parse(temp[1]), int.Parse(temp[2]));
        line = sr.ReadLine();
    }
    sr.Close();
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}

Console.WriteLine($"You need {wrappingPaper} square feet of wrapping paper");
Console.WriteLine($"You need {ribbon} feet of ribbon");


static int WrappingPaper(int length, int width, int height)
{
    int[] square = new int[3];
    square[0] = length * width;
    square[1] = length * height;
    square[2] = width * height;

    int slack = square.Min();
    
    return square.Sum() * 2 + slack;
}

static int Ribbon(int length, int width, int height)
{
    int[] size = new int[3];
    size[0] = (length + width) * 2;
    size[1] = (length + height) * 2;
    size[2] = (width + height) * 2;

    int wrap = size.Min();
    int bow = length * width * height;
    return wrap + bow;
}

