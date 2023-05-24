using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class STARTGAME : MonoBehaviour
{
  
    public GameObject tutorial;


    public GameObject score;
    public GameObject high_score;

    public GameObject starting;
    public GameObject obs;
    public GameObject obs1;
    public GameObject obs2;
    public GameObject obs3;
    public GameObject speeding;
    public GameObject speeding1;
    public GameObject speeding2;
    public GameObject speeding3;


    public GameObject pause;
    public GameObject spaceship;
    public GameObject store;
    public Player logic;

  // Start is called before the first frame update
    public void startgame()
    {
        spaceship.SetActive(true);
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<Player>();
        score.SetActive(true);
        starting.SetActive(false);
        if (PlayerPrefs.GetInt("scene", 0) == 2 || PlayerPrefs.GetInt("scene", 0) == 3)
        {
            speeding1.SetActive(true);

            obs1.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("scene", 0) == 0 || PlayerPrefs.GetInt("scene", 0) == 1)
        {
            speeding.SetActive(true);

            obs.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("scene", 0) == 4 || PlayerPrefs.GetInt("scene", 0) == 5)
        {
            speeding2.SetActive(true);

            obs2.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("scene", 0) == 6)
        {
            speeding3.SetActive(true);

            obs3.SetActive(true);
        }

        pause.SetActive(true);
        store.SetActive(false);
        high_score.SetActive(false);
       


        logic.t = true;
      
        if (PlayerPrefs.GetInt("tutorial", 0) == 0)
        {
            tutorial.SetActive(true);
            PlayerPrefs.SetInt("tutorial", 1);
        }
      
    }
    
}
