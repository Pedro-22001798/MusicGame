using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollJ : MonoBehaviour
{
    private bool detectjValue;
    private static bool colljValue;
    private static GameObject jnote;

    void Update()
    {
        detectjValue = NoteClick.returnjValue();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag == "Note")
        {
            jnote = col.gameObject;
            colljValue = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.transform.tag == "Note")
        {
            colljValue = false;
        }
    }

    public static bool CheckJColl()
    {
        return colljValue;
    }
    public static GameObject jNote()
    {
        return jnote;
    }
}
