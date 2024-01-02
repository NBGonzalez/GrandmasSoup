using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Observer2
{
    public class Hero : MonoBehaviour, Subject
    {
        public int Health { get; private set; }

        private readonly List<Observer> _observers;


        public Hero()
        {
            _observers = new List<Observer>();
            Health = 3;
            Notify();
        }
        public void Subscribe(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Updated(this);
            }
        }

        public void ApplyDamage(int damage)
        {
            Health -= damage;
            Notify();
        }
        public void Healing(int damage)
        {
            Health += damage;
            Notify();
        }
        
    }
}