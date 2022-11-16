using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ainguoi : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;

    UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {

        agent = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        if (target == null)
        {
            target = GameObject.FindGameObjectWithTag("QuaiVat");
        }
    }

    void Update()
    {


        agent.SetDestination(target.transform.position);



    }
    void OnCollisionEnter(Collision other)
    {


    }
}
