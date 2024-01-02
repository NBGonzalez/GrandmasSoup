using Components;
using Components.Interfaces;
using UnityEngine;

namespace Patterns.Observer.BadImplementation
{
    public class HealthBag : MonoBehaviour
    {
        private int _health = 2;

        private UIManager _uiManager;
        private SoundSystem _soundSystem;

        private void Start()
        {
            _uiManager = GameObject.Find("GameUI").GetComponent<UIManager>();
            _soundSystem = GameObject.Find("SoundSystem").GetComponent<SoundSystem>();
        }

        public void OnTriggerEnter(Collider other)
        {
            IPickableHealth pickable = other.GetComponent<IPickableHealth>();

            if (pickable != null)
            {
                _health += pickable.Pick();
                Debug.Log($"Gold: {_health}");

                // Actualiza el UI
                _uiManager.UpdateHealth(_health);

                // Reproducir sonido
                _soundSystem.PlayHealthSound();

                // Ejecutar el efecto
            }
        }
    }
}
