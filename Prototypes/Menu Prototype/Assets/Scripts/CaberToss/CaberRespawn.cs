using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaberRespawn : MonoBehaviour
{
    public Vector3 startPosition;
    public Quaternion startRotation;
    Scoring sc;
    
    void Start()
    {
        sc = GameObject.Find("ScoreTest").GetComponent<Scoring>();
    }
    private void Awake()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;

    }

    public void Retry()
    {
        /*Scene loadedLevel = SceneManager.GetActiveScene ();
        SceneManager.LoadScene (loadedLevel.buildIndex);*/
        transform.position = startPosition;
        transform.rotation = startRotation;
        
    }
}
