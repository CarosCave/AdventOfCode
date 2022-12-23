namespace Day_03;

public class Santa
{
    private Coord _coord;

    public Coord Coord
    {
        get
        {
            return _coord;
        }
    }
    
    public void Move(char direction)
    {
        switch (direction)
        {
            case '^':
                _coord.y += 1;
                break;
            case 'v':
                _coord.y -= 1;
                break;
            case '<':
                _coord.x -= 1;
                break;
            case '>':
                _coord.x += 1;
                break;
        }
        
    }
    
    public Santa()
    {
        _coord.x = 0;
        _coord.y = 0;
    }
}