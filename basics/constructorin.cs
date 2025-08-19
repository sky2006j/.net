class parent
{
    public parent()
    {
        System.Console.WriteLine("from parents");
    }
}
class child : parent
{
    public child()
    {
        System.Console.WriteLine("from child");
    }
}