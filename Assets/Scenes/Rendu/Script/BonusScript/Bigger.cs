using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bigger : MonoBehaviour
{
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
            collision.gameObject.transform.localScale += Vector3.one;
            Destroy(this.gameObject);
        }
        if (collision.gameObject.name == "DeadZone")
        {
            Destroy(this.gameObject);
        }
    }
}
