using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Mediator.Structural
{
    public class ConcreteMediator : Mediator
    {
        // public ConcreteColleague1 ConcreteColleague1;
        // public ConcreteColleague2 ConcreteColleague2;

        private List<Colleague> colleagues  = new List<Colleague>();

        public void Register(Colleague colleague)
        {
            colleague.SetMediator(this);
            this.colleagues.Add(colleague);
        }

        public override void Send(string message, Colleague colleague)
        {
            // if (colleague == this.ConcreteColleague1)
            // {
            //     this.ConcreteColleague2.HandleNotification(message);
            // }
            //
            // if (colleague == this.ConcreteColleague2)
            // {
            //     this.ConcreteColleague1.HandleNotification(message);
            // }

            this.colleagues.Where(c => c != colleague).ToList().ForEach(c => c.HandleNotification(message));
        }
    }
}
