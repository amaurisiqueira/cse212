public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            if (value != Data)
            {
                // Insert to the right
                if (Right is null)
                    Right = new Node(value);
                else
                    Right.Insert(value);
            }



        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2

        Node myNode = this;

        while (myNode != null)
        {
            if (value < myNode.Data)
            {
                myNode = myNode.Left;
            }
            else if (value > myNode.Data)
            {
                myNode = myNode.Right;
            }
            else
            {
                return true; // Encontramos el valor en el árbol
            }
        }
        return false;
    }

    public int GetHeight()
    {
        
        int leftCount = 0;
        int rigthCount = 0;
        Node myNode = this;
        while (myNode != null)
        {
            myNode = myNode.Left;
            if (myNode  is not null) leftCount++;
        }
        myNode = this;
        while (myNode != null)
        {
            myNode = myNode.Right;
            if (myNode  is not null) rigthCount++;
        }
        
        // TODO Start Problem 4
        return 1 + Math.Max(leftCount, rigthCount); ; // Replace this line with the correct return statement(s)
    }
}