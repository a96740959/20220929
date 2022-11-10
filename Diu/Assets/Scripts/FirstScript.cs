using UnityEngine;

namespace Alex
{
    /// <summary>
    /// First Script
    /// </summary>
    public class FirstScript : MonoBehaviour
    {
        #region Event
        private void Awake()
        {
            print("hello world!!");
        }

        private void Start()
        {
            print("<color=yellow>This is start event</color>");
        }

        private void Update()
        {
            print("<color=red>update event</color>");
        }
        #endregion
    }
}
