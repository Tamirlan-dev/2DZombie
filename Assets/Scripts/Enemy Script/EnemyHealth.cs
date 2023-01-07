using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int Health;
    public int zombieValue=0;
    public GameObject zombie;
    

    public void Awake()
    {
        Health = 100;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Health <= 0)
        {
            ScoreManager.instance.ChangeScore(zombieValue);
            print(zombieValue);
            Destroy(zombie);
           
        }
        
   
        if (collision.CompareTag("Melee"))
            {
                Health = Health - 10;
                print("-10hp");

            }
        if (collision.CompareTag("Short Sword"))
            {
                Health = Health - 20;
                print("-20hp");
            }
        if (collision.CompareTag("Long Sword"))
            {
                Health = Health - 50;
                print("-50hp");
            }
        if (collision.CompareTag("Axe"))
            {
                Health = Health - 50;
                print("-50hp");
            }
        if (collision.CompareTag("Mace"))
            {
                Health = Health - 25;
                print("-25hp");
            }
        if (collision.CompareTag("Hammer"))
            {
                Health = Health - 30;
                print("-30hp");
            }
        
        
       
    }

}
