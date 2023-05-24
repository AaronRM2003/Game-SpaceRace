using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audiostop : MonoBehaviour
{
    public GameObject audio1;

    public void stopaudio()
    {
        audio1.SetActive(false);
    }
    // Start is called before the first frame update
 
}
