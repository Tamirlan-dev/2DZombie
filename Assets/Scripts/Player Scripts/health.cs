using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class health : MonoBehaviour
{
    public int Health;


    public void Awake()
    {
        Health = 100;
   }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.CompareTag("Enemy"))
        {
            HPManager.instance.ChangeHealth(10);
        }
       


    }

    
}
