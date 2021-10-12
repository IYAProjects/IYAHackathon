using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemdestroyer : MonoBehaviour
{
void OnTriggerEnter2D(Collider2D other)
{
    AIcontroller controller = other.GetComponent<AIcontroller>();

    if (controller != null)
    {
        if(controller.currentHealth < controller.maxHealth)
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);
        }
    }
   
}

}