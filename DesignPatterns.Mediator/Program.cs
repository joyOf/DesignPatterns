using DesignPatterns.Mediator.Structural;

namespace DesignPatterns.Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var concreteMediator = new ConcreteMediator();

            var c1 = new ConcreteColleague1();
            var c2 = new ConcreteColleague2();
            var c3 = new ConcreteColleague3();

            concreteMediator.Register(c1);
            concreteMediator.Register(c2);
            concreteMediator.Register(c3);

            c1.Send("Here's the message from C1");
            // c2.Send("Here's the message from C2");
        }
    }
}
