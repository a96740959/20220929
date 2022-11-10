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

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.gameObject.name.Contains(Nametarget))
            {
                Instantiate(prefebExplosion, transform.position, transform.rotation);

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

