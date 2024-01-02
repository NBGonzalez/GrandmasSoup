using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Observer2
{
    public interface Observer
    {
        void Updated(Subject subject);
    }
}
