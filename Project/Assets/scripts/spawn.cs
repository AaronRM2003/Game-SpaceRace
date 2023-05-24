using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject Obstacle;
    public float spawnrate = 1;
    private float timer = 0;
    public float width = 10;
    public float deadZone = -11;
    // Start is called before the first frame update
    void Start()
    {
        spawnobs();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnobs();
            timer = 0;
        }
       
    }
    void spawnobs()
    {
        float leftpoint = transform.position.x - width;
        float rightpoint = transform.position.x + width;
       
            Instantiate(Obstacle, new Vector3(Random.Range(leftpoint, rightpoint), transform.position.y, 0), transform.rotation);

    }
}
