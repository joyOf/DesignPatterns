using System;

namespace DesignPatterns.Mediator.Structural

{
    public class ConcreteColleague2 : Colleague
    {
        // public ConcreteColleague2(Mediator mediator) : base(mediator)
        // {
        // }

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"ConcreteColleague2 receives notification message:{message}");
        }
    }
}
