/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spaceshippreff : MonoBehaviour
{
    public int preff;
   public void selectpref()
    {
        PlayerPrefs.SetInt("spacecraft", preff);

    }
}*/




using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spaceshippreff : MonoBehaviour
{
    public Player logic;
    public int preff1;
    public int cost;
    public static int clk;
    public int val;
    public static int clk3;
    public static int clk4;
    public static int clk5;
    public static int clk6;
    public static int clk7;
   



    public GameObject sce;
    public int money;
    void Start()
    {
        if (preff1 != 0 && preff1 != 1)
        {


            clk3 = PlayerPrefs.GetInt("s3", 0);
            clk4 = PlayerPrefs.GetInt("s4", 0);
            clk5 = PlayerPrefs.GetInt("s5", 0);
            clk6 = PlayerPrefs.GetInt("s6", 0);
            clk7 = PlayerPrefs.GetInt("s7", 0);
           


            if (clk3 == val || clk4 == val || clk5 == val || clk6 == val || clk7 == val)
            {
                sce.SetActive(false);
            }
            money = PlayerPrefs.GetInt("total score", 0);
        }
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<Player>();
    }
    public void selectpref()
    {
        if (preff1 == 0 || preff1 == 1 || preff1 == 7 || preff1 == 8)
        {
            PlayerPrefs.SetInt("spacecraft", preff1);

        }
       
        else
        {
            money = PlayerPrefs.GetInt("total score", 0);
            if (preff1 == 2)
            {
                if (money >= cost && clk3 == 0)
                {
                    money -= cost;
                    clk3 = val;
                    PlayerPrefs.SetInt("spacecraft", preff1);

                    PlayerPrefs.SetInt("total score", money);

                }

                PlayerPrefs.SetInt("s3", clk3);
            }
            if (preff1 == 3)
            {
                if (money >= cost && clk4 == 0)
                {
                    money -= cost;
                    clk4 = val;
                    PlayerPrefs.SetInt("spacecraft", preff1);

                    PlayerPrefs.SetInt("total score", money);

                }

                PlayerPrefs.SetInt("s4", clk4);
            }
            if (preff1 == 4)
            {
                if (money >= cost && clk5 == 0)
                {
                    money -= cost;
                    clk5 = val;
                    PlayerPrefs.SetInt("spacecraft", preff1);

                    PlayerPrefs.SetInt("total score", money);

                }

                PlayerPrefs.SetInt("s5", clk5);
            }
            if (preff1 == 5)
            {
                if (money >= cost && clk6 == 0)
                {
                    money -= cost;
                    clk6 = val;
                    PlayerPrefs.SetInt("spacecraft", preff1);

                    PlayerPrefs.SetInt("total score", money);

                }

                PlayerPrefs.SetInt("s6", clk6);
            }
            if (preff1 == 6)
            {
                if (money >= cost && clk7 == 0)
                {
                    money -= cost;
                    clk7 = val;
                    PlayerPrefs.SetInt("spacecraft", preff1);

                    PlayerPrefs.SetInt("total score", money);

                }

                PlayerPrefs.SetInt("s7", clk7);
            }

            if (clk3 == val)
            {
                PlayerPrefs.SetInt("spacecraft", preff1);
                sce.SetActive(false);
            }
            if (clk4 == val)
            {
                PlayerPrefs.SetInt("spacecraft", preff1);
                sce.SetActive(false);
            }
            if (clk5 == val)
            {
                PlayerPrefs.SetInt("spacecraft", preff1);
                sce.SetActive(false);
            }
            if (clk6 == val)
            {
                PlayerPrefs.SetInt("spacecraft", preff1);
                sce.SetActive(false);
            }
            if (clk7 == val)
            {
                PlayerPrefs.SetInt("spacecraft", preff1);
                sce.SetActive(false);
            }



        }

    }
}