using System.Text;

StreamReader sr = new StreamReader("201501_Input.txt", Encoding.UTF8);

string txt = sr.ReadToEnd();
sr.Close();

int etage = 0;
bool firstBasementEntry = false;
int valueFirstBasementEntry = 0;

foreach (char letter in txt)
{
    if (letter.Equals('('))
    {
        etage++;
    }

    if (letter.Equals(')'))
    {
        etage--;
    }

    if (!firstBasementEntry)
    {
        if (etage == -1)
        {
            firstBasementEntry = true;
        }

        valueFirstBasementEntry++;
    }
}

Console.WriteLine("Er befindet sich in Stockwerk: " + etage);
Console.WriteLine("Zum ersten mal betritt er das erste Untergeschoss nach: {0} Schritten", valueFirstBasementEntry);