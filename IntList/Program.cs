public class Program
{
    public int[] Array;
    public int Count;
    public int InitialSize = 4;

    public Program()
    {
        Array = new int[InitialSize];
    }

    //resize logic 
    public void ResizeUp()
    {
        var temp = new int[Array.Length * 2];
        for (var i = 0; i < Count; i++) temp[i] = Array[i];
        Array = temp;
    }
//for later use 
    // public void ResizeDown()
    // {
    //     var temp = new int[Array.Length / 2];
    //     for (var i = 0; i < Count; i++) temp[i] = Array[i];
    //     Array = temp;
    // }

    //isEmpty logic 
    public bool IsEmpty(int[] array)
    {
        return Count == 0;
    }

    public void Insert(int value, int index)
    {
        if (index > Count || index < 0)
        {
            Console.WriteLine("Cannot");
            return;
        }

        if (Count == Array.Length) ResizeUp();

        for (var i = Count; i > index; i--) Array[i] = Array[i - 1];
        Array[index] = value;
        Count++;
    }

    public void Add(int value)
    {
        if (Count < Array.Length)
        {
            Array[Count] = value;
            Count++;
        }
        else
        {
            ResizeUp();
            Array[Count] = value;
            Count++;
        }
    }

    public int RemoveAt(int index)
    {
       // if (Count == Array.Length / 2) ResizeDown();
        var result = Array[index];
        for (var i = index; i < Count - 1; i++) Array[i] = Array[i + 1];
        Count--;
        return result;
    }

    public int Size()
    {
        return Count;
    }

    public int Get(int index)
    {
        return Array[index];
    }

    public static void Main(string[] args)
    {
        var list = new Program();
        list.Add(4);
        list.Add(8);
        list.Add(15);
        Console.WriteLine(list.Count);   
        Console.WriteLine(list.Get(0));
        Console.WriteLine(list.Get(2));

        list.Insert(6, 1);             
        Console.WriteLine(list.Get(1));
        Console.WriteLine(list.Count);   

        list.Insert(1, 0);          

        list.Insert(9, 5);    
        Console.WriteLine(list.Count); 
        Console.WriteLine(list.Array.Length); 

        list.RemoveAt(2);                
        Console.WriteLine(list.Get(2));  
        Console.WriteLine(list.Count);   

        list.RemoveAt(0);           
        list.RemoveAt(list.Count - 1);
        Console.WriteLine(list.Get(0));
        Console.WriteLine(list.Get(2));
        Console.WriteLine(list.Count);   
        Console.WriteLine(list.Array.Length);
    }
}