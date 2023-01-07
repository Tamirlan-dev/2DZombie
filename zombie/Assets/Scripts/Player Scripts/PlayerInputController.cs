using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    private WeaponManager weaponManager;
    [HideInInspector]
    public bool canHit;
    private bool isHoldAttack;
    void Awake()
    {
        weaponManager = GetComponent<WeaponManager>();
        canHit = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            weaponManager.SwitchWeapon();
        }
        if (Input.GetKey(KeyCode.T))
        {
            isHoldAttack = true;
        }
        else
        {
            weaponManager.ResetAttack();
            isHoldAttack = false;
        }
        if (isHoldAttack && canHit)
        {
            weaponManager.Attack();
        }
    }
}
