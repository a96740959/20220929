using UnityEngine;

namespace Alex
{
    /// <summary>
    /// Object destory
    /// </summary>
    public class Destroy : MonoBehaviour
    {
        [SerializeField, Header("Delect Object Time"), Range(0, 3)]
        private float DestroyTime = 0.5f;

        private void Awake()
        {
            Destroy(gameObject, DestroyTime);
        }

        private void OnBecameVisible()
        {

        }

        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }
}

