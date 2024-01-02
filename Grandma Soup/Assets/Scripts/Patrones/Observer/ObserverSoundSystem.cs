using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Patterns.Observer.Interfaces;

namespace Patterns.Observer
{
    public class ObserverSoundSystem : MonoBehaviour, IObserver<int>
    {
        private AudioSource healthAudio;

        private void Awake()
        {
            GameObject player = GameObject.FindWithTag("Player");
            //ObserverGoldBag observerGoldBag = player.GetComponent<ObserverGoldBag>();
            //observerGoldBag.AddObserver(this);

            healthAudio = GetComponent<AudioSource>();
        }

        public void UpdateObserver(int data)
        {
            healthAudio?.Play();
        }
    }
}
