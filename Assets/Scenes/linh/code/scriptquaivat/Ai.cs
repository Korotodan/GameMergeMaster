using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ai : MonoBehaviour
{
    // Start is called before the first frame update
    public float rangeattack;
    public GameObject target;
    private float range;
    Animator anima;
    UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {
        anima = gameObject.GetComponent<Animator>();
        agent = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        if (target == null)
        {
            target = GameObject.FindGameObjectWithTag("Nguoi");
        }
    }

    void Update()
    {


        agent.SetDestination(target.transform.position);
        range = Vector3.Distance(target.transform.position, this.gameObject.transform.position);
        FindAgent();

    }
    void FindAgent()
    {
        if (range > rangeattack)
        {
            
            anima.SetBool("Run", true);
            anima.SetBool("Attack", false);
        }
        else if (range <= rangeattack && target!=null)
        {
            anima.SetBool("Run", false);
            anima.SetBool("Attack", true);

        }
        else if(target== null)
        {
            anima.SetBool("Run", false);
            anima.SetBool("Attack", false);
        }

    }
    
}
