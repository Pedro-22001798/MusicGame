using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectLossPoints : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag == "-Points")
        {
            NoteClick.lossPoints();
        }
    }
}
