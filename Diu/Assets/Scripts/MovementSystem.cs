using UnityEngine;

namespace Alex
{
    /// <summary>
    /// Movement System
    /// </summary>
    public class MovementSystem : MonoBehaviour
    {
        [SerializeField, Header("MoveSpeed"), Range(-10, 0)]
        private float Speed = -3.5f;

        private void Update()
        {
            transform.Translate(Speed * Time.deltaTime, 0, 0);
        }
    }

}
