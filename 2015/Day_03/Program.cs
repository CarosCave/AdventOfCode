using System.Text;
using Day_03;

StreamReader sr = new StreamReader("201503_Input.txt", Encoding.UTF8);

string txt = sr.ReadToEnd();
sr.Close();
bool odd = false;

Dictionary<Coord, int> houses = new Dictionary<Coord, int>();

int VisitsMoreThanOnce = 0;
int VisitsOnlyOnce = 0;

Santa santa = new Santa();
Santa roboSanta = new Santa();

houses.Add(santa.Coord, 1);
houses[roboSanta.Coord]++;

string txt1 = "^v";
string txt2 = ">"; // No multiple visits
string txt3 = "^>v<"; // One multiple visit
string txt4 = "^v^v^v^v^v"; // Two houses get mutliple visits

foreach (char direction in txt)
{
    if (!odd)
    {
        santa.Move(direction);
    
        if (houses.ContainsKey(santa.Coord))
        {
            houses[santa.Coord]++;
        }
        else
        {
            houses.Add(santa.Coord, 1);
        }

        odd = true;
    }
    else
    {
        roboSanta.Move(direction);
    
        if (houses.ContainsKey(roboSanta.Coord))
        {
            houses[roboSanta.Coord]++;
        }
        else
        {
            houses.Add(roboSanta.Coord, 1);
        }

        odd = false;
    }
    
}

foreach (KeyValuePair<Coord,int> house in houses)
{
    if (house.Value > 1)
    {
        VisitsMoreThanOnce++;
    }
    if (house.Value == 1)
    {
        VisitsOnlyOnce++;
    }
}

Console.WriteLine($"He visits {VisitsMoreThanOnce} Houses more than once.");
Console.WriteLine($"He visits {VisitsOnlyOnce} house once.");
Console.WriteLine($"He visits in total {houses.Count} houses");