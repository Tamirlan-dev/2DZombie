using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArmController : MonoBehaviour
{
    public Sprite one_hand_sprite, two_hand_sprite;
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();

    }
    public void ChangeToOneHand()
    {
        sr.sprite = one_hand_sprite;
    }
    public void ChangeToTwoHand()
    {
        sr.sprite = two_hand_sprite;
    }
   
}
