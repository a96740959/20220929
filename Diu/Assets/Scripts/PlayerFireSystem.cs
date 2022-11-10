using UnityEngine;

namespace Alex
{
    /// <summary>
    /// Player shooting system
    /// </summary>
    public class PlayerFireSystem : FireSystemBase
    {
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }
    }
}

