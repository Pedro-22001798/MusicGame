using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteClick : MonoBehaviour
{
    [SerializeField] private GameObject[] buttons;
    private Color pressedNote;
    private Color normalNote;

    private static bool gValue = false;
    private static bool hValue = false;
    private static bool jValue = false;

    private bool gColl;

    private float gTimer = 10f;

    void Start()
    {
        normalNote = new Color(255, 255, 255);
        pressedNote = new Color(0, 0, 0);
    }

    void Update()
    {
        print(gTimer);
        gColl = DetectColl.CheckGColl();

        if (Input.GetButtonDown("g"))
        {
            buttons[0].GetComponent<Renderer>().material.SetColor("_Color", pressedNote);
            gValue = true;
            if(gColl == true)
            {
                Destroy(DetectColl.gNote());
            }
            else
            {
                print("Colisão error");
            }
        }
        else
        {
            buttons[0].GetComponent<Renderer>().material.SetColor("_Color", normalNote);
            gValue = false;
        }
        if (Input.GetButton("h"))
        {
            buttons[1].GetComponent<Renderer>().material.SetColor("_Color", pressedNote);
            hValue = true;
        }
        else
        {
            buttons[1].GetComponent<Renderer>().material.SetColor("_Color", normalNote);
            hValue = false;
        }
        if (Input.GetButton("j"))
        {
            buttons[2].GetComponent<Renderer>().material.SetColor("_Color", pressedNote);
            jValue = true;
        }
        else
        {
            buttons[2].GetComponent<Renderer>().material.SetColor("_Color", normalNote);
            jValue = false;
        }
    }

    public static bool returngValue()
    {
        return gValue;
    }
    public static bool returnhValue()
    {
        return hValue;
    }
    public static bool returnjValue()
    {
        return jValue;
    }
}
