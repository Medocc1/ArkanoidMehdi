using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public GameObject brickManager;
    public int score;
    public TMP_Text scorePrompt;
    private Transform[] children;
    // Start is called before the first frame update
    void Start()
    {
        children = brickManager.GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        scorePrompt.text = $"Score: {score}";
        if (children.Length == 1)
        {

        }
    }
}
