using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace linh
{
    public class M : MonoBehaviour
    {
        public int level;
        private int atk;
        private int hp;
        private int gold;
        private int spd;

        
        public int Atk1 { get => atk; set => atk = value; }
        public int Hp1 { get => hp; set => hp = value; }
        public int Gold1 { get => gold; set => gold = value; }
        public int Spd { get => spd; set => spd = value; }

        void Start()
        {


        }

        // Update is called once per frame
        void Update()
        {
            Atk(Atk1,level);
            Hp(Hp1,level);
            Gold();

        }

        public static int Atk(int atk, int level)
        {
            atk = 12;
            for (int i = 0; i < level; i++)
            {
                atk = atk * 2 + 1;
            }
            return atk;
        }
       public static int Hp(int hp ,int level)
        {
            hp = 80;
            for (int i = 0; i < level; i++)
            {
                hp = hp * 2;
            }

            return hp;

        }
        public void Gold()
        {
            Gold1 = 100;
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
