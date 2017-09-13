using System;


    public abstract class AbstractFightForce : IFightForce
    {
        public Commander Commander { get; }

        public Fraction Fraction{ get;}

        public BattleResult Battle(Army army)
        {
            throw new NotImplementedException();
        }
        //private Commander commander;

    }
