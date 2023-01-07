using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    public int score;
    public GameObject win;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    public void ChangeScore(int zombieValue)
    {
        score += zombieValue;
        text.text = "X" + score.ToString();
        if (score >= 45)
        {
            
             win.SetActive(true);
            
        }
    }
}
