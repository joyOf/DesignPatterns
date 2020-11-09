namespace DesignPatterns.Mediator.Structural
{
    public abstract class Colleague
    {
        private Mediator _mediator;

        // protected Colleague(_mediator mediator)
        // {
        //     this._mediator = mediator;
        // }

        internal void SetMediator(Mediator mediator)
        {
            this._mediator = mediator;
        }

        public void Send(string message)
        {
            this._mediator.Send(message, this);
        }

        public abstract void HandleNotification(string message);
    }
}
