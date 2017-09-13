using System.Collections.Generic;


    public class Fraction
    {
        private Resources globalResources;
        private IList<IAbility> abilities;

        public string Name { get; private set; }
        private bool playable;

        public Fraction(string name, Resources resources, List<IAbility> abilities, bool playable)
        {
            this.Name = name;
            this.globalResources = resources;
            this.abilities = abilities;
            this.playable = playable;
        }

        public IFractionPolicy WhatToDo(Fraction fraction)
        {
            //TODO logika stosunku jednej frackji do srugiej
            if (fraction.Equals (this))
                return new EmptyFractionPolicy ();
            return null;
        }
    }
