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

    public float attackTime;
    private float attackTimer;
    private int roundedAttackTime;

    public int health;

    void Update()
    {
        if (attackTimer > 0)
        {
            attackTimer -= Time.deltaTime;
            roundedAttackTime = Mathf.RoundToInt(attackTimer);
        }

        distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

        if(distanceToPlayer <= findRadius && distanceToPlayer >= attackRadius)
        {
            agent.destination = player.transform.position;
        }

        if (distanceToPlayer <= attackRadius)
        {
            transform.LookAt(playerFeet.transform.position);
            agent.destination = transform.position;

            if(roundedAttackTime == 0)
            {
                attackTimer = attackTime;
                player.GetComponent<PlayerMec>().DoDamage(damage);
            }
        }
    }

    public void DoDamage(int damageToDo)
    {
        health -= damageToDo;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
