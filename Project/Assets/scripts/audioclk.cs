using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioclk : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource click;

    public void clkaudio()
    {
        click.Play();
    }
}
