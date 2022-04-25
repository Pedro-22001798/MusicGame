using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollH : MonoBehaviour
{
    private bool detecthValue;
    private static bool collhValue;
    private static GameObject hnote;

    void Update()
    {
        detecthValue = NoteClick.returnhValue();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag == "Note")
        {
            hnote = col.gameObject;
            collhValue = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.transform.tag == "Note")
        {
            collhValue = false;
        }
    }

    public static bool CheckHColl()
    {
        return collhValue;
    }
    public static GameObject hNote()
    {
        return hnote;
    }
}
