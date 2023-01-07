using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NameWeapon
{
    MELEE,
    SHORTSWORD,
    MACE,
    HAMMER,
        AXE,
    LONGSWORD

}

public class WeaponController : MonoBehaviour
{

    public DefaultConfing defaultConfing;
    public NameWeapon nameWp;
    public Transform spawnPoint;
    public int currentDurability;
    public int maxDurability;
    //protected PlayerAnimation playerAnim;
    protected float lastHit;

   

    void Awake()
    {
        //anim = GetComponentInParent<PlayerAnimation>();
        currentDurability = maxDurability;
    }

 
    public void CallAttack()
    {
        if(Time.time> lastHit + defaultConfing.hitRate)
        {
            if (currentDurability> 0){
               // ProcessAttack();
                // playerAnim.AttackAnimation();
                lastHit = Time.time;
                currentDurability--;
            }
            else
            {
                //Play broke weapon sound

            }
        }
    }
    
    public void ProcessAttack()
    {

    }
   
}
