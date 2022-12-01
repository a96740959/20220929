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
        [SerializeField, Header("SoundFx")]
        private AudioClip soundFire;

        protected void SpawnBullet()
        {
            Instantiate(PrefebBullet, PointSpawn.position, PointSpawn.rotation);

            SoundManager.instance.PlaySound(soundFire, new Vector2(0.7f, 1.2f));
        }
    }
}

