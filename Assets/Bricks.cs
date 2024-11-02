using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    [SerializeField] private GameObject bonusToDropRed;
    [SerializeField] private GameObject bonusToDropBlue;
    [SerializeField] private int dropRate;
    private int drop;
    private int hp;
    private Renderer rd;
    private Vector3 spawnBonus;

    void Start()
    {
        hp = Random.Range(1, 4);
        Debug.Log(hp);
        rd = this.gameObject.GetComponent<Renderer>();
        if (hp == 3)
        {
            rd.material.color = Color.blue;
        }
        else
        {
            rd.material.color = Color.red;
        }
        spawnBonus = transform.position;
        drop = Random.Range(1, 11);
    }
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            hp -= 1;
            if (hp == 0)
            {
                if (drop > dropRate)
                {
                    if (rd.material.color == Color.blue)
                    {
                        Instantiate(bonusToDropBlue, spawnBonus, Quaternion.identity);
                    }
                    else if (rd.material.color == Color.red)
                    {
                        Instantiate(bonusToDropRed, spawnBonus, Quaternion.identity);
                    }
                }
                Destroy(this.gameObject);
            }
        }
    }
}
