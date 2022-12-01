using UnityEngine;

namespace Alex
{
    /// <summary>
    /// Enemy shooting system
    /// </summary>
    public class EnemyFireSystem : FireSystemBase
    {
        [SerializeField, Header("SpawnCooldown"), Range(0, 3)]
        protected float interval = 1.5f;

        private void Awake()
        {
            
        }
        private void OnBecameVisible()
        {
            InvokeRepeating("SpawnBullet", 0, interval);
        }

        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }

}
