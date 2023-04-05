using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

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
    public Slider healthbar;

    private Vector3 startPos;

    public void Start()
    {
        startPos.x = transform.position.x;
        startPos.z = transform.position.z;
    }

    public void Update()
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
            agent.destination = transform.position;

            if(roundedAttackTime == 0)
            {
                attackTimer = attackTime;
                player.GetComponent<PlayerMec>().DoDamage(damage);
            }
        }

        if(distanceToPlayer >= findRadius && startPos != transform.position)
        {
            agent.destination = startPos;
        }

        healthbar.value = health;
        
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
