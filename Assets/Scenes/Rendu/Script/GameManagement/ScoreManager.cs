using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public GameObject brickManager;
    public int score;
    public TMP_Text scorePrompt;
    private Transform[] children;
    // Start is called before the first frame update
    void Start()
    {
        if (brickManager != null)
        {
            children = brickManager.GetComponentsInChildren<Transform>();
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        scorePrompt.text = $"Score: {score}";
        if (children != null)
        {
            if (children.Length == 1)
            {
                SceneManager.LoadScene(2);
            }

        }
    }
}
