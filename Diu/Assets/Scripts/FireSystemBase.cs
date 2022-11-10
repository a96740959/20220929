using UnityEngine;

namespace Alex
{
    /// <summary>
    /// Base of Firing System
    /// 1.Bullet spawning
    /// </summary>
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("Bullet")]
        private GameObject PrefebBullet;
        [SerializeField, Header("BulletSpawnPoint")]
        private Transform PointSpawn;

        protected void SpawnBullet()
        {
            Instantiate(PrefebBullet, PointSpawn.position, PointSpawn.rotation);
        }
    }
}

