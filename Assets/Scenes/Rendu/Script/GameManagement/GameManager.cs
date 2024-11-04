using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int playerLifes;
    public TMP_Text lifePrompt;
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
        if (playerLifes == 0)
        {
            SceneManager.LoadScene(2);
        }
        if (lifePrompt != null)
        {
        lifePrompt.text = $"Player lifes {playerLifes}";
        }
        if (scorePrompt != null)
        {
            scorePrompt.text = $"Score: {score}";
        }
        if (children != null)
        {
            if (children.Length == 1)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
