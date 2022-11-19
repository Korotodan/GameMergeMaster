using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideQuaiVat : MonoBehaviour
{
    public Attack quaivat;
    private GameObject target;

    private void Start()
    {
        if(this.gameObject.name == "QuaiVat")
        {
            target = GameObject.FindGameObjectWithTag("Nguoi");
        }
        
       

    }
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Map")
        {
            quaivat.DealDamage(target.gameObject);
        }

    }
}
