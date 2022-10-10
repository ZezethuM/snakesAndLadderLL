namespace SnakesFunction;

public class Snakes
{
    public Node? First{get; set;}
    public Node? Last{get; set;}
    //public Node? MoveNode{get; set;}
    public int MoveInt{get; set;}

   

    public void AddFirst(int value, int index)
    {
        Node newNode = new Node(value, index);

        if(First == null)
        {
            First = newNode;
            Last = newNode;
        }
        else{
            newNode.Next = First;
            First = newNode;
        }

    }
    public void AddLast(int value, int index)
    {
         Node newNode = new Node(value, index);
        if(First == null)
        {
            First = newNode;
            Last = newNode;
        
        }else{
            Last!.Next = newNode;
            Last = newNode;
        }
    }

    public int Move(int count)
    {
        
        int temp = MoveInt + count;
        MoveInt += Find(temp).Value;
        return MoveInt;
            

        // else
        // {
            
        // }


    }
    public void DisplayList()
    {
        Node current = First!;
        while(current != null)
        {
            current.Display();
            current = current.Next!;
        }
    }

    public int indexOf(int value)
    {
        int index = 0;
        Node current = First!;
        while(current != null)
        {
            if(current.Value == value)
            {
                return index;
            }
            else
            {
                current = current.Next!;
                index++;
            }
        }
        return -1; 
    }
    public bool Contain(int values)
    {
      return indexOf(values) != -1 ;
    }

    public Node Find(int value)
    {
        Node currentNode = First!;
        while(currentNode != null)
        {
            if(currentNode.Value == value)
            {
                return currentNode;
            }
            currentNode = currentNode.Next!;
        }
        // Andre
        return currentNode!;
    }
}
