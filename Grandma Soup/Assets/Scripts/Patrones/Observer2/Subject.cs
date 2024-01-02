using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Observer2
{
    public interface Subject
    {
        void Subscribe(Observer observer);
        void Unsubscribe(Observer observer);
        void Notify();
    }
}
