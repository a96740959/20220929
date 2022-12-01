using UnityEngine;

namespace Alex
{
    /// <summary>
    /// Determinate that player died or pass
    /// </summary>
    public class PlayerFinal : MonoBehaviour
    {
        private void OnDestroy()
        {
            EndGameCanvasManager.instance.GameOver("You Lose!");
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            EndGameCanvasManager.instance.GameOver("You Win!!");
        }
    }
}
