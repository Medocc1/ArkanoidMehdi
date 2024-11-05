using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slower : MonoBehaviour
{
    private GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            Ball = GameObject.Find("Ball");
            Ball.GetComponent<BallScript>().ballSpeed *= 0.5f;
            Destroy(this.gameObject);
        }
        if (collision.gameObject.name == "DeadZone")
        {
            Destroy(this.gameObject);
        }
    }
}
