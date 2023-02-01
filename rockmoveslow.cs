using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class rockmoveslow : MonoBehaviour
{
    public Transform player;

    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Main Camera").transform; 
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = player.position;
        agent.speed = 0.5f;
    }
}