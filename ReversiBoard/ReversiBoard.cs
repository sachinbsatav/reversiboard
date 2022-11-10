namespace ReversiBoard;

public class Board
{
    private readonly Tile[,] _squares;

    public int BlackCount { get; private set; }
    public int EmptyCount { get; private set; }
    public int WhiteCount { get; private set; }

    public Dictionary<Player, int> PlayerInfo { get; private set; }
    public Player CurrentPlayer { get; private set; }
    public Player Winner { get; private set; }

    public Board()
    {
        var BlackPlayer = new Player { Color = PlayerColor.Black };
        var WhitePlayer = new Player { Color = PlayerColor.White };

        _squares = new Tile[8, 8];

        BlackCount = EmptyCount = WhiteCount = 0;

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                _squares[i, j] = new Tile
                {
                    State = GetInitialState(i, j),
                    Position = new Tuple<int, int>(i, j)
                };
            }
        }

        PlayerInfo = new Dictionary<Player, int>()
        {
            {BlackPlayer, 2 },
            {WhitePlayer, 2 }
        };

        CurrentPlayer = BlackPlayer;
    }

    private TileState GetInitialState(int i, int j)
    {
        if (i == 3 && j == 3)
            return TileState.White;
        else if (i == 3 && j == 4)
            return TileState.Black;
        else if (i == 4 && j == 3)
            return TileState.Black;
        else if (i == 4 && j == 4)
            return TileState.White;
        else
            return TileState.Empty;
    }

    public Board(Board board)
    {
        _squares = board._squares;

        BlackCount = board.BlackCount;
        EmptyCount = board.EmptyCount;
        WhiteCount = board.WhiteCount;

    }

    public void Print()
    {
        for (int i = 0; i < 8; i++)
            Console.Write($"\t{i}");

        for (int j = 0; j < 8; j++)
        {
            Console.Write($"\n\n{j}");
            int i = 0;
            while (i < 8)
            {
                Console.Write($"\t{(int)_squares[i, j].State}");
                i++;
            }
        }

    }
}