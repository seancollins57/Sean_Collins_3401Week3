using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AIMotor : MonoBehaviour
{

    public NavMeshAgent agent;
    public Transform destination;
    public float movespeed = 100;
   

    void Start()
    {
        
    }


    void Update()
    {

        agent.SetDestination(destination.position);

        movespeed -= Time.deltaTime;

    }
}
