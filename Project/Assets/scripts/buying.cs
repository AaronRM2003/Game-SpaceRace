using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buying : MonoBehaviour
{
    public GameObject instore;
    public GameObject buy;
    public GameObject inbuy;

    // Start is called before the first frame update
    public void onclkbuy()
    {
        instore.SetActive(false);
        buy.SetActive(false);
        inbuy.SetActive(true);
    }
    public void onclkback()
    {
        inbuy.SetActive(false);

        instore.SetActive(true);
        buy.SetActive(true);
    }
}
