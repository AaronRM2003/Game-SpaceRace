using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obs : MonoBehaviour
{
    public float speed=5;
    public float delay = 10;
    public float timer = 0;
    public Player logic;
    public bool b1 = true;
    public bool b2 = true;
    public bool b3 = true;
    public bool b4 = true;
    public bool b5 = true;
    public bool b6 = true;
    public bool b7 = true;
    public bool b8 = true;
    // Start is called before the first frame update
    void Start()
    {
       

        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.position += Vector3.down * speed * Time.deltaTime;
        transform.Rotate(0,0, Random.Range( 6* 10 * Time.deltaTime, 1* 10 * Time.deltaTime));
        if (transform.position.y < -20 && gameObject != null)
        {
            Destroy(gameObject);
            if (logic.t)
            {

                if (PlayerPrefs.GetInt("spacecraft", 0) == 1 || PlayerPrefs.GetInt("spacecraft", 0) == 0)
                {
                    if (b1)
                    {
                        logic.score += 1;
                        b1 = false;
                        b2 = true;
                        b3 = true;
                        b4 = true;
                        b5 = true;
                        b6 = true;
                        b7 = true;
                        b8 = true;

                    }
                }
                if (PlayerPrefs.GetInt("spacecraft", 0) == 2)
                {
                    if (b2)
                    {
                        logic.score += 2;
                        b2 = false;
                        b1 = true;
                        b3 = true;
                        b4 = true;
                        b5 = true;
                        b6 = true;
                        b7 = true;
                        b8 = true;

                    }
                }
                if (PlayerPrefs.GetInt("spacecraft", 0) == 3)
                {
                    if (b3)
                    {
                        logic.score += 4;
                        b3 = false;
                        b2 = true;
                        b1 = true;
                        b4 = true;
                        b5 = true;
                        b6 = true;
                        b7 = true;
                        b8 = true;

                    }
                }
                if (PlayerPrefs.GetInt("spacecraft", 0) == 4)
                {
                    if (b4)
                    {
                        logic.score += 6;
                        b4 = false;
                        b2 = true;
                        b3 = true;
                        b1 = true;
                        b5 = true;
                        b6 = true;
                        b7 = true;
                        b8 = true;

                    }
                }
                if (PlayerPrefs.GetInt("spacecraft", 0) == 5)
                {
                    if (b5)
                    {
                        logic.score += 8;
                        b5 = false;
                        b2 = true;
                        b3 = true;
                        b4 = true;
                        b1 = true;
                        b6 = true;
                        b7 = true;
                        b8 = true;

                    }
                }
                if (PlayerPrefs.GetInt("spacecraft", 0) == 6)
                {
                    if (b6)
                    {
                        logic.score += 10;
                        b6 = false;
                        b2 = true;
                        b3 = true;
                        b4 = true;
                        b5 = true;
                        b1 = true;
                        b7 = true;
                        b8 = true;

                    }
                }
                if (PlayerPrefs.GetInt("spacecraft", 0) == 7)
                {
                    if (b6)
                    {
                        logic.score += 12;
                        b7 = false;
                        b2 = true;
                        b3 = true;
                        b4 = true;
                        b5 = true;
                        b1 = true;
                        b6 = true;
                        b8 = true;

                    }
                }
                if (PlayerPrefs.GetInt("spacecraft", 0) == 8)
                {
                    if (b6)
                    {
                        logic.score += 14;
                        b8 = false;
                        b2 = true;
                        b3 = true;
                        b4 = true;
                        b5 = true;
                        b1 = true;
                        b7 = true;
                        b6 = true;

                    }
                }
            }
        }
     
    }
}
