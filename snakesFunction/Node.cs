namespace SnakesFunction
{
    public class Node 
    {
        public int Value{get; set;}
        public int LadderIndex{get; set;}
        public Node? Next{get; set;}

        public Node(int value, int index)
        {
            this.Value = value;
            this.LadderIndex = index;
        }

        public void Display()
        {
            Console.WriteLine($"Value: {Value}, Index: {LadderIndex}");
        }
    }
}