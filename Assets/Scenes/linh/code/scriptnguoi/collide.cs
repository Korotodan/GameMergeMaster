using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide : MonoBehaviour

{
    public Attack nguoi;
    public Attack quaivat;
    private GameObject target;

    
    private void Start()
    {
        if (this.gameObject.name == "Nguoi")
        {
            target = GameObject.FindGameObjectWithTag("QuaiVat");
            
        }
        else
        {
            target = GameObject.FindGameObjectWithTag("Nguoi");
        }

        
       
    }
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Map"&& this.gameObject.name == "Nguoi")
        {
            nguoi.DealDamage(target.gameObject);
        }
        else
        {
            quaivat.DealDamage(target.gameObject);
        }  
    }
}
