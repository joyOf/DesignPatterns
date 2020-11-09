using System;

namespace DesignPatterns.Mediator.Structural
{
    public class ConcreteColleague3 : Colleague
    {
        // public ConcreteColleague3(Mediator mediator) : base(mediator)
        // {
        // }

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"ConcreteColleague3 receives notification message:{message}");
        }
    }
}
