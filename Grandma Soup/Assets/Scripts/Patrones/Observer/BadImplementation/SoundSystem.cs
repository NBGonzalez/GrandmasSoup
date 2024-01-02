using UnityEngine;

namespace Patterns.Observer.BadImplementation
{
    public class SoundSystem : MonoBehaviour
    {
        private AudioSource _healthAudio;

        private void Awake()
        {
            _healthAudio = GetComponent<AudioSource>();
        }

        public void PlayHealthSound()
        {
            _healthAudio?.Play();
        }
    }
}
