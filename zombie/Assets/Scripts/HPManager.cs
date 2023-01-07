using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HPManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static HPManager instance;
    public TextMeshProUGUI text;
    public GameObject[] hearts = new GameObject[4];
    int hp=100;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    public void ChangeHealth(int damage)
    {
        hp -= damage;
        text.text = "    :" + hp.ToString();
        if (hp <= 70&& hp>30)
        {
            hearts[1].SetActive(true);
        }else if (hp <= 30&&hp>0)
        {
            hearts[2].SetActive(true);
        }
        else if(hp<=0) hearts[3].SetActive(true);
    }
}
