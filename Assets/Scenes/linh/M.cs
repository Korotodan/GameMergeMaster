using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M : MonoBehaviour
{
    public float level;
    private float atk;
    private float hp;
    private float gold;
    private float spd;

    void Start()
    {
   
       
    }

    // Update is called once per frame
    void Update()
    {
        Atk();
        Hp();
        Gold();
        
    }

    public void Atk()
    {
        atk = 12f;
        for(int i=0; i< level; i++)
        {
            atk = atk * 2 + 1;
        }
        Debug.Log(atk);
    }
    public void Hp()
    {
        hp = 80f;
        for (int i = 0; i < level; i++)
        {
            hp = hp * 2;
        }
        Debug.Log(hp);

    }
    public void Gold()
    {
        gold = 100f;
        for(int i=0;i<level; i++)
        { if( i == 0)
            {
                gold = gold + 60;
            }else if (i == 2)
            {
                gold = gold + 160;
            }
            else
            {
                gold = gold * 2;
            }

        }
        Debug.Log(gold);
    }


    

}
