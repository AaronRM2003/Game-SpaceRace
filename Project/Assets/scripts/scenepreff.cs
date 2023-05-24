using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scenepreff : MonoBehaviour
{
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
          



            clk3 = PlayerPrefs.GetInt("sc3", 0);
            clk4 = PlayerPrefs.GetInt("sc4", 0);
            clk5 = PlayerPrefs.GetInt("sc5", 0);
            clk6 = PlayerPrefs.GetInt("sc6", 0);
            clk7 = PlayerPrefs.GetInt("sc7", 0);

            if (clk3 == val || clk4 == val || clk5 == val || clk6 == val || clk7 == val)
            {
                sce.SetActive(false);
            }
            money = PlayerPrefs.GetInt("total score", 0);
        }
    }
    public void selectpref()
    {
        if (preff1 == 0 || preff1 == 1)
        {
            PlayerPrefs.SetInt("scene", preff1);

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
                    PlayerPrefs.SetInt("scene", preff1);

                    PlayerPrefs.SetInt("total score", money);

                }

                PlayerPrefs.SetInt("sc3", clk3);
            }
            if (preff1 == 3)
            {
                if (money >= cost && clk4 == 0)
                {
                    money -= cost;
                    clk4 = val;
                    PlayerPrefs.SetInt("scene", preff1);

                    PlayerPrefs.SetInt("total score", money);

                }

                PlayerPrefs.SetInt("sc4", clk4);
            }
            if (preff1 == 4)
            {
                if (money >= cost && clk5 == 0)
                {
                    money -= cost;
                    clk5 = val;
                    PlayerPrefs.SetInt("scene", preff1);

                    PlayerPrefs.SetInt("total score", money);

                }

                PlayerPrefs.SetInt("sc5", clk5);
            }
            if (preff1 == 5)
            {
                if (money >= cost && clk6 == 0)
                {
                    money -= cost;
                    clk6 = val;
                    PlayerPrefs.SetInt("scene", preff1);

                    PlayerPrefs.SetInt("total score", money);

                }

                PlayerPrefs.SetInt("sc6", clk6);
            }
            if (preff1 == 6)
            {
                if (money >= cost && clk7 == 0)
                {
                    money -= cost;
                    clk7 = val;
                    PlayerPrefs.SetInt("scene", preff1);

                    PlayerPrefs.SetInt("total score", money);

                }

                PlayerPrefs.SetInt("sc7", clk7);
            }

            if (clk3 == val)
            {
                PlayerPrefs.SetInt("scene", preff1);
                sce.SetActive(false);
            }
            if (clk4 == val)
            {
                PlayerPrefs.SetInt("scene", preff1);
                sce.SetActive(false);
            }
            if (clk5 == val)
            {
                PlayerPrefs.SetInt("scene", preff1);
                sce.SetActive(false);
            }
            if (clk6 == val)
            {
                PlayerPrefs.SetInt("scene", preff1);
                sce.SetActive(false);
            }
            if (clk7 == val)
            {
                PlayerPrefs.SetInt("scene", preff1);
                sce.SetActive(false);
            }


        }

    }
}