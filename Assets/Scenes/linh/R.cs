using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R : MonoBehaviour
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
        Spd();

    }

    public void Atk()
    {
        atk = 5f;
        for (int i = 0; i < level; i++)
        {
            atk = atk * 2 ;
        }
        Debug.Log(atk);
    }
    public void Hp()
    {
        hp = 36f;
        for (int i = 0; i < level; i++)
        {
            hp = hp * 2;
        }
        Debug.Log(hp);

    }
    public void Gold()
    {
        gold = 100f;
        for (int i = 0; i < level; i++)
        {
            if (i == 0)
            {
                gold = gold + 60;
            }
            else if (i == 2)
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
    public void Spd()
    {
        spd = 1f;
        if(level==0|| level==1|| level == 2)
        {
            spd = 1f;

        }else if( level==3|| level==4|| level == 5)
        {
            spd = 1.2f;
        }else if(level==6|| level == 7 || level == 8)
        {
            spd = 1.3f;
        }else
        {
            spd = 1.5f;
        }
        Debug.Log(spd);
    }
}
