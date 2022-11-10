using UnityEngine;

namespace Alex
{
    /// <summary>
    /// Player Controller
    /// </summary>
    public class PlayerController : MonoBehaviour
    {
        [Header("MoveSpeed")]
        [SerializeField, Range(0, 10)]
        private float MoveVertical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float MoveHorizontal = 4f;

        [Header("Picture")]
        [SerializeField]
        private Sprite PictureUp;
        [SerializeField]
        private Sprite PictureMiddle;
        [SerializeField]
        private Sprite PictureDown;

        [Header("PictureRender")]
        [SerializeField]
        private SpriteRenderer Spr;

        private void Update()                                                 
        {
            float v = Input.GetAxis("Vertical");
            float h = Input.GetAxis("Horizontal");

            transform.Translate(
                MoveHorizontal * Time.deltaTime * h                                                   ,
                MoveVertical * Time.deltaTime * v,
                0);

            if(v > 0)
            {
                print("Up");

                Spr.sprite = PictureUp;
            }
            if(v < 0)
            {
                print("Down");

                Spr.sprite = PictureDown;
            }
            if(v == 0)
            {
                print("Middle");

                Spr.sprite = PictureMiddle;
            }
        }
    }
}
