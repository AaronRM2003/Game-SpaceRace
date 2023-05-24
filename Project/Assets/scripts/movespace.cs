using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movespace : MonoBehaviour
{
    public float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down *0.02f* Time.deltaTime;
    }
}
