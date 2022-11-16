using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace linh
{
    public class M : MonoBehaviour
    {
        public  float level;
        private float atk;
        private float hp;
        private float gold;
        private float spd;

        public float Atk1 { get => atk; set => atk = value; }
        public float Hp1 { get => hp; set => hp = value; }
        public float Gold1 { get => gold; set => gold = value; }
        public float Spd { get => spd; set => spd = value; }

        void Start()
        {


        }

        // Update is called once per frame
        void Update()
        {
            Atk(atk, level);
            Hp(hp,level);
            Gold();

        }

        public static float Atk(float atk, float level)
        {
            atk = 12f;
            for (int i = 0; i < level; i++)
            {
                atk = atk * 2 + 1;
            }
            return atk;
        }
       public static float Hp(float hp ,float level)
        {
            hp = 80f;
            for (int i = 0; i < level; i++)
            {
                hp = hp * 2;
            }

            return hp;

        }
        public void Gold()
        {
            Gold1 = 100f;
            for (int i = 0; i < level; i++)
            {
                if (i == 0)
                {
                    Gold1 = Gold1 + 60;
                }
                else if (i == 2)
                {
                    Gold1 = Gold1 + 160;
                }
                else
                {
                    Gold1 = Gold1 * 2;
                }

            }
            Debug.Log(Gold1);
        }




    }

}
