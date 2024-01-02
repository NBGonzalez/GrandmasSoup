using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections.Generic;
using Components.Interfaces;
using Patterns.Observer.Interfaces;
using UnityEngine;

namespace Patterns.Observer
{
    public class ObserverHealthBag : MonoBehaviour, ISubject<int>
    {
        [SerializeField] public int health = 1;

        // REFACTORIZACION DE LA RECOGIDA DE MONEDAS
        public void OnTriggerEnter(Collider other)
        {
            IPickableHealth pickable = other.GetComponent<IPickableHealth>();
            Debug.Log("Hola");

            if (pickable != null)
            {
                health += pickable.Pick();
                NotifyObservers();
            }
        }

        // IMPLEMENTACION DEL PATRON OBSERVER
        private List<IObserver<int>> _observers = new List<IObserver<int>>();

        public void AddObserver(IObserver<int> observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver<int> observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver<int> observer in _observers)
            {
                observer?.UpdateObserver(health);
            }
        }
    }
}
