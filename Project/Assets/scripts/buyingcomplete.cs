using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;


public class buyingcomplete : MonoBehaviour
{
    public static int ad;
    public static int c1;
    public static int c2;
    public static int c3;
    public static int s1;
    public static int s2;


    public GameObject text008;
    public GameObject text009;

    public GameObject ads;
    public GameObject adsbutton;

    // Start is called before the first frame update
    void Start()
    {
       /* if (new SubscriptionManager().getSubscriptionInfo().isSubscribed() == Result.False)
        {
            PlayerPrefs.SetInt("ads removed", 0);
        }*/

        ad = PlayerPrefs.GetInt("ads removed", 0);
        if (ad == 1)
        {
            ads.SetActive(false);
            adsbutton.SetActive(false);
        }
        if (PlayerPrefs.GetInt("spacecraft8", 0) == 7)
        {
          
            text008.SetActive(false);
        }
        if (PlayerPrefs.GetInt("spacecraft9", 0) == 8)
        {
          
            text009.SetActive(false);
        }

    }

    // Update is called once per frame
    public void OnRemovingAdsComplete()
    {
        ads.SetActive(false);
        PlayerPrefs.SetInt("ads removed", 1);
        adsbutton.transform.position = new Vector3(adsbutton.transform.position.x, adsbutton.transform.position.y, -1500);

    }

    public void OnBuying1000coins()
    {
        c1=PlayerPrefs.GetInt("total score", 0);
        c1 += 1000;
        PlayerPrefs.SetInt("total score", c1);
    }

    public void OnBuying10000coins()
    {
        c2 = PlayerPrefs.GetInt("total score", 0);
        c2 += 10000;
        PlayerPrefs.SetInt("total score", c2);
    }

    public void OnBuying100000coins()
    {
        c3 = PlayerPrefs.GetInt("total score", 0);
        c3 += 100000;
        PlayerPrefs.SetInt("total score", c3);
    }

    public void BuyingSpacecraft008()
    {
        PlayerPrefs.SetInt("spacecraft", 7);
        PlayerPrefs.SetInt("spacecraft8", 7);
      

        text008.SetActive(false);

    }
    public void BuyingSpacecraft009()
    {
        PlayerPrefs.SetInt("spacecraft", 8);
        PlayerPrefs.SetInt("spacecraft9", 8);
    

        text009.SetActive(false);

    }
}
