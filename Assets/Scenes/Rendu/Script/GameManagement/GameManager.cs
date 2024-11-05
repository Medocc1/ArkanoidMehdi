using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int PlayerLifes;
    public TMP_Text LifePrompt;
    public GameObject BrickManager;
    public int Score;
    public TMP_Text ScorePrompt;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(BrickManager.transform.childCount);
        if (PlayerLifes == 0)
        {
            SceneManager.LoadScene(2);
        }
        if (LifePrompt != null)
        {
        LifePrompt.text = $"Player lifes {PlayerLifes}";
        }
        if (ScorePrompt != null)
        {
            ScorePrompt.text = $"Score: {Score}";
        }
        if (BrickManager != null)
        {
            if (BrickManager.transform.childCount == 0)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
