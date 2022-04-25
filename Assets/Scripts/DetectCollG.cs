using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollG : MonoBehaviour
{
    private bool detectgValue;
    private static bool collgValue;
    private static GameObject gnote;

    void Update()
    {
        detectgValue = NoteClick.returngValue();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag == "Note")
        {
            gnote = col.gameObject;
            collgValue = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.transform.tag == "Note")
        {
            collgValue = false;
        }
    }

    public static bool CheckGColl()
    {
        return collgValue;
    }
    public static GameObject gNote()
    {
        return gnote;
    }
}
