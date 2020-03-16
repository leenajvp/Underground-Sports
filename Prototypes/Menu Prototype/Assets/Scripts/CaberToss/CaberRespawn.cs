using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaberRespawn : MonoBehaviour
{
    public Vector3 startPosition;
    public Quaternion startRotation;
    Scoring sc;
    
    void Start()
    {

    }
    /*private void Awake()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;

    }*/

    public void Retry()
    {
        Scene loadedLevel = SceneManager.GetActiveScene ();
        SceneManager.LoadScene (loadedLevel.buildIndex);
        /*transform.position = startPosition;
        transform.rotation = startRotation;*/
    }
}
