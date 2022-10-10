using SnakesFunction;

Snakes test = new Snakes();

// test.AddFirst(1,38);
// test.AddLast(2, -1);
// test.AddLast(3, -1);
// test.AddLast(4, 14);
// test.AddLast(5, -1);
// test.AddLast(6, -1);
// test.AddLast(7, -1);
// test.AddLast(8, 10);
// test.AddLast(9, -1);
// test.AddLast(10, -1);
// test.AddLast(11, -1);
// test.AddLast(12, -1);
// test.AddLast(13, -1);
// test.AddLast(14, -1);
// test.AddLast(15, -1);
// test.AddLast(16, -1);
// test.AddLast(17, -1);
// test.AddLast(18, -1);
// test.AddLast(19, -1);
// test.AddLast(, 14);

Dictionary<int, int> board = new Dictionary<int, int>()
{
    {1, 38}, {4, 14}, {8, 10}, {21, 42}, {28, 76}, {50, 67}, {71, 92}, {88, 10}
};

for (int i = 0; i <= 100; i++)
{
    if(board.ContainsKey(i))
    {
        test.AddLast(i, board[i]);
    }
    else
    {
        test.AddLast(i, -1);
    }
}

Console.WriteLine(test.Move(5));



// if(test.Contain(38))
// {
//     Console.WriteLine(test.Find(38).Value);
// };

//test.DisplayList();



