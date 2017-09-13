using System.Collections.Generic;


    public class Army : AbstractFightForce
    {
        private IList<Unit> units;

        public Army ()
        {
        }

        public BattleResult Battle(Army army)
        {
            return BattleResult.WIN;
        }

        //TODO merdzowanie armii
    }
