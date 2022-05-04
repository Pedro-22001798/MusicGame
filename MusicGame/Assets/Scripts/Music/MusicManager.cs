using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource theMusic;


    
    void Start()
    {
        StartCoroutine (SecondsToStart());
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    IEnumerator SecondsToStart()
    {
        yield return new WaitForSeconds (4);
        theMusic.Play();
    }
}
