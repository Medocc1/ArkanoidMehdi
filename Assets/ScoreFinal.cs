using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreFinal : MonoBehaviour
{
    public TMP_Text scorePrompt;
    private GameObject scoreStocker;
    // Start is called before the first frame update
    void Start()
    {
        scoreStocker = GameObject.Find("DeadZone");
        scorePrompt.text = $"Score : {scoreStocker.GetComponent<GameManager>().score}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
