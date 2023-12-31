using Patterns.ObjectPool.Interfaces;
using UnityEditor.Rendering;
using UnityEngine;

namespace Patterns.ObjectPool.Components
{
    public class AcidDrop : MonoBehaviour, IPooleableObject
    {
        public float speed = 1f;

        public IObjectPool pool;
        private void Update()
        {
            if (transform.position.y < -15 || Physics.CheckSphere(transform.position, 0.25f,
                    LayerMask.GetMask("Default"), QueryTriggerInteraction.Ignore))
            {
                pool?.Release(this);
            }
        }

        private void FixedUpdate()
        {
            transform.position += Vector3.down * (speed * Time.fixedDeltaTime);
            transform.position += Vector3.left * (speed / 2 * Time.fixedDeltaTime);
        }

        public bool Active
        {
            get
            {
                return gameObject.activeSelf;
            }

            set
            {
                gameObject.SetActive(value);
            }
        }

        public void Reset()
        {
            transform.localPosition = Vector3.zero;
            // Debug.Log($"New SnowFlake initialized at: {transform.position}");
        }

        public IPooleableObject Clone()
        {
            GameObject newObject = Instantiate(gameObject);
            AcidDrop snowFlake = newObject.GetComponent<AcidDrop>();
            return snowFlake;
        }
    }
}