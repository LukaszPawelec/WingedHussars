
    public class ConflictFractionPolicy
    {
        public VisitResult Solve(IFightForce host, IFightForce guest)
        {
            host.Battle(guest);

            return VisitResult.IGNORE;
        }
    }
