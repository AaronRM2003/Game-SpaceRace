using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscore : MonoBehaviour
{
    public GameObject starting;
    public GameObject store;
    public GameObject high_score;
    public GameObject score_text;
    public GameObject highscore11;

    // Start is called before the first frame update
   

    public static int highscore1;
    public static int score;
  
  

    public Player scores;

    public Text text;
   

    void Start()
    {
        scores= GameObject.FindGameObjectWithTag("logic").GetComponent<Player>();

        highscore1=PlayerPrefs.GetInt("highscore",0);
      
        text.text = highscore1+"";
    }

    void Update()
    {
        score = (int)scores.score;
        if (score > highscore1)
        {
            highscore1 = score;
            text.text = highscore1.ToString();
            PlayerPrefs.SetInt("highscore", highscore1);
            
        }
       
      





    }
    public void onhighscore()
    {
        starting.SetActive(false);
        store.SetActive(false);
        high_score.SetActive(false);
        score_text.transform.position = new Vector3(score_text.transform.position.x, score_text.transform.position.y, 0);
        highscore11.SetActive(true);

    }
    public void outhighscore()
    {
        starting.SetActive(true);
        store.SetActive(true);
        high_score.SetActive(true);
        score_text.transform.position = new Vector3(score_text.transform.position.x, score_text.transform.position.y, -1500);
        highscore11.SetActive(false);


    }
   
 

}
