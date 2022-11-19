using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using linh;

public class Attack : MonoBehaviour
{
    public int level;
    private int health;
    private int damage;
    void Start()
    {
        health = linh.M.Hp(80, level);
        damage = linh.M.Atk(12, level);
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<Attack>();
        if (atm != null)
        {
            atm.TakeDamage(damage);
        }
    }
}
