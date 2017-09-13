
    public class EmptyFractionPolicy : IFractionPolicy 
    {

        public VisitResult Solve(IFightForce host, IFightForce guest)
        {
            return VisitResult.IGNORE;
        }
    }
