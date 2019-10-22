using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public double timeBetweenAttacks = 0.5f;
    public double Damage = 10f;
   



    GameObject player;
    Health PlayerHealth;

    double timer;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        PlayerHealth = player.GetComponent<Health>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
      // GameObject objectCollided = collider.gameObject;
        //Health damageableComponent = objectCollided.GetComponent<Health>();
        //if (damageableComponent)
//        { 
//
  //      }
       if (collider.gameObject == player)
        {
           Attack();
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (PlayerHealth.CurrentHP <= 0)
        {
            
        }
    }

    void Attack()
    {
        timer = 0;
        if (PlayerHealth.CurrentHP > 0)
        {
            PlayerHealth.TakeDamage(Damage);
        }
    }
}
