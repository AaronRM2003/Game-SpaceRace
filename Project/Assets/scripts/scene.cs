using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scene : MonoBehaviour
{
    public Image sc1;
    public Image sc2;
    public Image sc3;
    public Image sc4;
    public Image sc5;
    public Image sc6;
    public Image sc7;
    public static int clk3;
    public static int clk4;
    public static int clk5;
    public static int clk6;
    public static int clk7;
    public GameObject sce3;
    public GameObject sce4;
    public GameObject sce5;
    public GameObject sce7;
    public GameObject sce6;





    public int money;

    public SpriteRenderer space;

    void Start()
    {


        /*money = PlayerPrefs.GetInt("total score", 0);
        clk3 = PlayerPrefs.GetInt("sc3", 0);
        if (clk3 == 1)
        {
            sce3.SetActive(false);
        }
        clk4 = PlayerPrefs.GetInt("sc4", 0);
        if (clk4 == 1)
        {
            sce4.SetActive(false);
        }
        clk5 = PlayerPrefs.GetInt("sc5", 0);
        if (clk5 == 1)
        {
            sce5.SetActive(false);
        }
        clk6 = PlayerPrefs.GetInt("sc6", 0);
        if (clk6 == 1)
        {
            sce6.SetActive(false);
        }
        clk7 = PlayerPrefs.GetInt("sc7", 0);
        if (clk7 == 1)
        {
            sce7.SetActive(false);
        }*/

    }
    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("scene", 0) == 0)
        {
            space.sprite = sc1.sprite;
        }
        if (PlayerPrefs.GetInt("scene", 0) == 1)
        {
            space.sprite = sc2.sprite;
        }
        if (PlayerPrefs.GetInt("scene", 0) == 2)
        {
           /* if (money >= 10 && clk3==0  )
            {
                money -= 10;
                clk3 = 1;
                space.sprite = sc3.sprite;
                PlayerPrefs.SetInt("total score", money);

            }
           
            PlayerPrefs.SetInt("sc3", clk3);
           

            if (clk3 == 1)
            {*/
                space.sprite = sc3.sprite;
               // sce3.SetActive(false);
           // }

        }
        if (PlayerPrefs.GetInt("scene", 0) == 3)
        {
          /*  if (money >= 2000 && clk4 == 0)
            {
                money -= 2000;
                clk4 = 1;
                space.sprite = sc4.sprite;
                PlayerPrefs.SetInt("total score", money);


            }
            PlayerPrefs.SetInt("sc4", clk4);

            if (clk4 == 1)
            {*/
                space.sprite = sc4.sprite;
              //  sce4.SetActive(false);

           // }
        }
        if (PlayerPrefs.GetInt("scene", 0) == 4)
        {
          /*  if (money >= 5000 && clk5 == 0)
            {
                money -= 5000;
                clk5 = 1;
                space.sprite = sc5.sprite;
                PlayerPrefs.SetInt("total score", money);

            }
            PlayerPrefs.SetInt("sc5", clk5);

            if (clk5 == 1)
            {*/
                space.sprite = sc5.sprite;
              //  sce5.SetActive(false);

            //}
        }
        if (PlayerPrefs.GetInt("scene", 0) == 5)
        {
           /* if (money >= 10000 && clk6 == 0)
            {
                money -= 10000;
                clk6 = 1;
                space.sprite = sc6.sprite;
                PlayerPrefs.SetInt("total score", money);


            }
            PlayerPrefs.SetInt("sc6", clk6);

            if (clk6 == 1)
            {*/
                space.sprite = sc6.sprite;
               // sce6.SetActive(false);

            //}
        }
        if (PlayerPrefs.GetInt("scene", 0) == 6)
        {
            /*if (money >= 20000 && clk7 == 0)
            {
                money -= 20000;
                clk7 = 1;
                space.sprite = sc7.sprite;
                PlayerPrefs.SetInt("total score", money);


            }
            PlayerPrefs.SetInt("sc7", clk7);

            if (clk7 == 1)
            {*/
                space.sprite = sc7.sprite;
               // sce7.SetActive(false);

            //}
        }

        
    }
}
