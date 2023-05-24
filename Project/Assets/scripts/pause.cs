using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pause : MonoBehaviour
{
    public GameObject score;
    public GameObject pausing;
    public GameObject pausebutton;
    // Start is called before the first frame update
    public void pausegame()
    {
        score.SetActive(false);
        pausing.SetActive(true);
        pausebutton.SetActive(false);


        Time.timeScale = 0; 
    }
}
