using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public GameObject BrickManager;
    public int Score;
    public TMP_Text ScorePrompt;
    private Transform[] children;
    // Start is called before the first frame update
    void Start()
    {
        if (BrickManager != null)
        {
            children = BrickManager.GetComponentsInChildren<Transform>();
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        ScorePrompt.text = $"Score: {Score}";
        if (children != null)
        {
            if (children.Length == 1)
            {
                SceneManager.LoadScene(2);
            }

        }
    }
}
