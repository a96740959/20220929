using UnityEngine;

namespace Alex
{
    /// <summary>
    /// Damage System
    /// </summary>
    public class damageSystem : MonoBehaviour
    {
        [SerializeField, Header("ObjectDealdamage")]
        private string Nametarget;

        [SerializeField, Header("PrefebExplosion")]
        private GameObject prefebExplosion;

        [Header("Hit and explosion soundFx")]
        [SerializeField]
        private AudioClip soundHit;
        [SerializeField]
        private AudioClip soundExplosion;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.gameObject.name.Contains(Nametarget))
            {
                Instantiate(prefebExplosion, transform.position, transform.rotation);

                SoundManager.instance.PlaySound(soundHit, new Vector2(0.5f, 0.9f));
                SoundManager.instance.PlaySound(soundExplosion, new Vector2(1.1f, 1.5f));

                Destroy(gameObject);
            }
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }

        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
    }
}

