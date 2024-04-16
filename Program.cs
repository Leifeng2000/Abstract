internal class Program
{
    private static void Main(string[] args)
    {
        Tiger myTiger = new Tiger();
        myTiger.Breathe();
        myTiger.Move();
        myTiger.Eat();

        Turtle myTurtle = new Turtle();
        myTurtle.Breathe();
        myTurtle.Move();
        myTurtle.Eat();

        Animal myCat = new Tiger();
        myCat.Breathe();
        myCat.Move();
        myCat.Eat();
        //

        Tiger MyTigerBlack = new TigerBlack();
        MyTigerBlack.Eat();
        MyTigerBlack.Move();
        MyTigerBlack.Breathe();
    }
}