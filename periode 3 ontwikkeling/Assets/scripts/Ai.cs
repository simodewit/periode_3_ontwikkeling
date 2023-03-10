using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ai : MonoBehaviour
{
    public GameObject player;
    public GameObject playerFeet;
    public NavMeshAgent agent;
    private float distanceToPlayer;
    public float findRadius;
    public float attackRadius;
    public int damage;

    void Update()
    {
        distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

        if(distanceToPlayer <= findRadius && distanceToPlayer >= attackRadius)
        {
            agent.destination = player.transform.position;
        }

        if (distanceToPlayer <= attackRadius)
        {
            transform.LookAt(playerFeet.transform.position);
            agent.destination = transform.position;

            player.GetComponent<PlayerMec>().DoDamage(damage);
        }
    }
}
