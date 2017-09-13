using System;
using System.Collections.Generic;


    public class Province
    {
        private Fraction Fraction{ get; set; }
        private IList<IFightForce> presentForces;
        
        private String name;
        private Resources localResources;
        private IList<IAbility> abilities;

        public Province(string name, Resources localResources, IList<IAbility> abilities)
        {
            this.name = name;
            this.localResources = localResources;
            this.abilities = abilities;
        }


        public void VisitBy(Army army)
        {
            //kazdy FF pyta swojej frakcji co robic w stosunku do goscia (walka. wycofanie, ignoruje) 
            //IFractionPolicy policy = Fraction.WhatToDo (army.Fraction);

            //kolekcja tych ktorzy walczą
            //fightForces  wyliczyc


            VisitResult result = policy.Solve (army, new CompoundFightingForce(fightForces));
            //TODO
            switch (result)
            {
                case VisitResult.LOOSE:
                    ChangeOwner(army.Fraction);
                    break;
            }
        }

        private void ChangeOwner(Fraction newFraction)
        {
            this.Fraction = newFraction;
            //ZOSTAWIC ABILITYCH CHARAKTERYSTYCZNE dla prowiznjci, zmienic frakcyjne, zalozyc garnizon, stacjonują wojska ktore przyzly, przejmujemy zasoby lokalne
        }

        public void MoveOut(Army army)
        {
            fightForces.Remove(army);
        }
    }
