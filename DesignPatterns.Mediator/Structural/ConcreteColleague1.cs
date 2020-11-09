using System;

namespace DesignPatterns.Mediator.Structural
{
    public class ConcreteColleague1 : Colleague
    {
        // public ConcreteColleague1(Mediator mediator) : base(mediator)
        // {
        // }

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"ConcreteColleague1 receives notification message:{message}");
        }
    }
}
