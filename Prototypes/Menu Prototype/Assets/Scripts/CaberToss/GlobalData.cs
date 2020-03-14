using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalData : MonoBehaviour
{
    static public int Scoring;
    public GameObject player;
    
    public Text scoreText;
    public Text scoreText2;
    
    void Awake()
    {
        Scoring = 0;
        SetDistance();
    }
    
    public void SetDistance()
    {
        scoreText.text = Scoring.ToString();
        scoreText2.text = Scoring.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
