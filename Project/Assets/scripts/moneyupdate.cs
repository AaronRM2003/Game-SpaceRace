using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moneyupdate : MonoBehaviour
{
    public Text money;
    public static int tscore;
    public Player l;
    bool n=true;
    // Start is called before the first frame update
    void Start()
    {
        tscore = PlayerPrefs.GetInt("total score", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (l.t == false)
        {
            if (n)
            {
                tscore += (int)l.score;
                money.text = tscore + "$";
                n = false;
                PlayerPrefs.SetInt("total score", tscore);
            }
        }
        if (l.t == true)
        {
            n = true;
        }
    
        tscore = PlayerPrefs.GetInt("total score", 0);
        money.text = tscore + "";

      


    }
    
}
