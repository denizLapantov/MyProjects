namespace FClubBarcelona.Service
{
    using Data;

    public abstract class Service
    {
        protected FClubBarcelonaContext Context { get; }

        protected Service()
        {
            this.Context = new FClubBarcelonaContext();
        }

    }
}
