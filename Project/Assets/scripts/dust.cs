using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dust : MonoBehaviour
{
    public float speed;
    public float delay = 10;
    public float timer = 0;
    public Player logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.down * speed * Time.deltaTime;
     
        if (transform.position.y < -20 && gameObject != null)
        {
            Destroy(gameObject);
            if (logic.t)
            {
                logic.score += 1;
            }
        }
    }
}
