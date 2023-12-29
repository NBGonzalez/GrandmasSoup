using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Patterns.Prototype.Interfaces;

namespace Patterns.Prototype
{
    public class RedSoldier : AbstractRat
    {
        public RedSoldier() : base("RedArmy")
        {
        }

        public override IPrototypeRat Clone()
        {
            IPrototypeRat newInstance = new RedSoldier();
            newInstance.Create();
            return newInstance;
        }
    }
}
