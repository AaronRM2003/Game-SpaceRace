using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class speed : MonoBehaviour
{
    public obs s;
    public obs u;
    public obs v;
    public obs w;
    public dust t;
    public GameObject obstacle;
    public GameObject asteroid;
    public GameObject asteroid1;
    public GameObject asteroid2;
    public GameObject dust;
    public float delay = 20;
    public float timer = 0;
    // Start is called before the first frame update

    void Start()
    {
        s = obstacle.GetComponent<obs>();
        u = asteroid.GetComponent<obs>();
        v = asteroid1.GetComponent<obs>();
        w = asteroid2.GetComponent<obs>();
        t= dust.GetComponent<dust>();
        s.speed = 5;
        u.speed = 5;
        v.speed = 5;
        w.speed = 5;
        t.speed = 5;

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < delay)
        {
            timer += Time.deltaTime;
        }
        else
        {
            s.speed += 1;
            u.speed += 1;
            v.speed += 1;
            w.speed += 1;
            t.speed += 1;

            timer = 0;
        }
    }
}
