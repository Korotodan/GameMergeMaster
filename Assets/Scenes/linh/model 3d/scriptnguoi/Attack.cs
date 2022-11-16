using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using linh;

public class Attack : MonoBehaviour
{
    public float level;
    private float heal;
    private float damage;


    // Start is called before the first frame update
    void Start()
    {
        heal= M.Hp(80f, level);
      
        damage = M.Atk(12f, level);
    }

    // Update is called once per frame
    void Update()
    {
       
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "QuaiVat" || collision.gameObject.name == "QuaiVat(Clone)")
        {
            atk();

        }
        if (heal < 0)
        {
            Destroy(this.gameObject);
            Debug.Log("Nguoi chet");
        }

    }
    public void atk()
    {
        heal -= damage;
        Debug.Log("Mat mau");
        Debug.Log(heal);
        if (heal == 0)
        {
            Destroy(this.gameObject);
            Debug.Log("Nguoi chet");
        }
    }
   
}
