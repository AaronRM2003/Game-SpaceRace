using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Store : MonoBehaviour
{
    public GameObject instore;
    public GameObject starting;
    public GameObject store;
    public GameObject spaceship;
    public GameObject highscore;
    public GameObject tscore;
    public GameObject highscore1;
    public GameObject buy;

 
  
    public void openstore() 
    {
        instore.SetActive(true);
        buy.SetActive(true);

        store.SetActive(false);
        starting.SetActive(false);
        tscore.transform.position = new Vector3(tscore.transform.position.x, tscore.transform.position.y, 0);
        highscore.SetActive(false);
        highscore1.SetActive(false);


    }


    public void goback()
    {
        buy.SetActive(false);

        highscore.SetActive(true);
        tscore.transform.position = new Vector3(tscore.transform.position.x, tscore.transform.position.y, 1500);
        instore.SetActive(false);
        store.SetActive(true);
        starting.SetActive(true); 
        highscore1.SetActive(true);

    }
    public void removeads()
    {

        store.SetActive(false);
        starting.SetActive(false);
        highscore.SetActive(false);
        highscore1.SetActive(false);

    }

}
