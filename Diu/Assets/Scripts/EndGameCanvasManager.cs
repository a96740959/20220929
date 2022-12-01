using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

namespace Alex
{
    /// <summary>
    /// Endgame manager
    /// </summary>
    public class EndGameCanvasManager : MonoBehaviour
    {
        public static EndGameCanvasManager instance;

        private CanvasGroup groupFinal;

        private TextMeshProUGUI textTitle;

        private Button btnRestart;

        private void Awake()
        {
            instance = this;

            groupFinal = GameObject.Find("EndGameCanvas").GetComponent<CanvasGroup>();
            textTitle = GameObject.Find("EndTitle").GetComponent<TextMeshProUGUI>();
            btnRestart = GameObject.Find("Restart").GetComponent<Button>();
            btnRestart.onClick.AddListener(Replay);
        }

        public void GameOver(string title)
        {
            textTitle.text = title;
            StartCoroutine(FadeIn());
        }

        /// <summary>
        /// Endgame canvas fade in
        /// </summary>
        /// <returns></returns>
        private IEnumerator FadeIn()
        {
            for (int i = 0; i < 10; i++)
            {
                groupFinal.alpha += 0.1f;
                yield return new WaitForSeconds(0.02f); 
            }

            groupFinal.interactable = true;
            groupFinal.blocksRaycasts = true;
        }

        private void Replay()
        {
            SceneManager.LoadScene("AlexKuanhandsomeBoiii");
        }
    }

}
