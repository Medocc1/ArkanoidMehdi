using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class LifesManager : MonoBehaviour
{
    public int playerLifes;
    public TMP_Text lifePrompt;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerLifes == 0)
        {
            
        }
        lifePrompt.text = $"Player lifes {playerLifes}";
    }
}
