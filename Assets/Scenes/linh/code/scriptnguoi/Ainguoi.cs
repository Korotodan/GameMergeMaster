using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ainguoi : MonoBehaviour
{
    // Start is called before the first frame update
    public float rangeattack;
    public GameObject target;
    private Animator anima;
    private float range;

    UnityEngine.AI.NavMeshAgent agent;
    

    void Start()
    {
        anima = gameObject.GetComponent<Animator>();
        agent = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        if (target == null)
        {
            target = GameObject.FindGameObjectWithTag("QuaiVat");
        }
    }

    void Update()
    {


        agent.SetDestination(target.transform.position);
        range = Vector3.Distance(target.transform.position, this.gameObject.transform.position);
        FindAngent();

    }
    private void FindAngent()
    {
        if (range > rangeattack)
        {
            
            anima.SetBool("Walking", true);
            anima.SetBool("Attack", false);
        }
        if (range <=rangeattack)
        {
            anima.SetBool("Walking", false);
            anima.SetBool("Attack", true);
        }

    }
    
}
