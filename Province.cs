using System.Collections.Generic;

namespace AssemblyCSharp
{
    public class Province
    {
        private Fraction Fraction{ get; set; }
        private IList<IFightForce> presentForces;
        private IList<IAbility> abilities;

        private Resources localResources;

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
}