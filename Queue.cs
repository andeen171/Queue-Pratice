class Queue
{
    private int[] vet;
    private int start;
    private int end;

    public Queue(int tam)
    {
        vet = new int[tam];
        start = end = 0;
    }

    public void Enqueue(int i)
    {
        vet[end] = i;
        end = (end + 1) % vet.Length;
    }

    public int Dequeue()
    {
        int item = vet[start];
        start = (start + 1) % vet.Length;
        return item;
    }

    public bool IsEmpty()
    {
        return start == end;
    }

    public bool IsFull()
    {
        return ((end + 1) % vet.Length) == start;
    }
}
