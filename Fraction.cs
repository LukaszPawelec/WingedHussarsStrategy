using System.Collections.Generic;

namespace AssemblyCSharp
{
    public class Fraction
    {
        private Resources globalResources;

        private IList<IAbility> abilities;

        public IFractionPolicy WhatToDo(Fraction fraction)
        {
            //TODO logika stosunku jednej frackji do srugiej
            if (fraction.Equals (this))
                return new EmptyFractionPolicy ();
            return null;
        }
    }
}