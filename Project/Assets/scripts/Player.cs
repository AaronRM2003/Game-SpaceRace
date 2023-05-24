using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float spawnrate = 1;
    private float timer = 0;
    public GameObject tutorial;



    public GameObject gameover;
    public GameObject pause;
  

    public GameObject pausing;
    public GameObject scoress;
    public float scores=0;
    public float score;
    public Text scoreText;
    public bool t=false;
    public GameObject currentscore;

// Start is called before the first frame update
void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

       
       
        if (t)
        {
          
            scoreText.text = score.ToString();
        }
        if (tutorial.activeSelf == true)
        {

            if (timer < spawnrate)
            {
                timer += Time.deltaTime;
            }
            else
            {
                tutorial.SetActive(false);
                timer = 0;
            }
        }


    }
    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale=1;
    }

    public void gameOver()
    {
        gameover.SetActive(true);
        Time.timeScale = 0;
        currentscore.SetActive(false);
        pause.SetActive(false);

    }
    public void resumegame()
    {
        Time.timeScale = 1;
        pause.SetActive(true);
      
        pausing.SetActive(false);
        scoress.SetActive(true);

        
    }


}
