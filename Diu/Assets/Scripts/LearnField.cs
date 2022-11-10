using UnityEngine;

namespace Alex
{
    public class LearnField : MonoBehaviour
    {
        private int Lv;

        public int enemy = 5;


        public float speed = 4.5f;
        public float jump = 8.5f;

        public string nameplayer = "HongDog";

        public bool Pass = false;
        public bool Weapon = true;

        [Header("LifePool")]
        public int HP = 100;

        [Tooltip("Playtime")]
        public float playtime = 10.5f;

        [Range(1, 99)]
        public int Level = 1;

        [Range(2, 99)]
        public float WalkSpeed = 2.5f;

    }

}
