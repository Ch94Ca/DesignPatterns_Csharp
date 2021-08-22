namespace ChainOfResponsibility.Middlewares
{
    abstract class Middleware
    {
        public Middleware Next { get; set; }

        public Middleware LinkWith(Middleware next)
        {
            Next = next;
            return next;
        }

        protected bool CheckNext(string email, string password)
        {
            if(Next == null)
            {
                return true;
            }

            return Next.Check(email, password);

        }

        public abstract bool Check(string email, string password);
    }
}
