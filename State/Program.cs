using System;

namespace State
{
    public enum Item
    {
        Walk,
        Fly
    }

    class Client
    {
        static void Main(string[] args)
        {
            Mario myMario = new Mario();

            myMario.Move();

            myMario.Eat(Item.Fly);
            myMario.Move();

            myMario.Eat(Item.Walk);
            myMario.Move();

            myMario.Eat(Item.Walk);
            myMario.Move();
        }
    }
}
