using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spacescenes : MonoBehaviour
{
    public GameObject space;
    public GameObject space1;
    public GameObject space2;

    public void spacescene()
    {
        space.SetActive(true);
        space1.SetActive(false);
        space2.SetActive(false);

    }
}
