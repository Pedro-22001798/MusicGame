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
    private bool hColl;
    private bool jColl;

    private static int points;
    [SerializeField] private Text pointsText;
    public ParticleSystem particleG;
    public ParticleSystem particleH;
    public ParticleSystem particleJ;

    [SerializeField] private GameObject personagem;

    //[SerializeField] private ParticleSystem hitParticles;

    void Start()
    {
        normalNote = new Color(255, 255, 255);
        pressedNote = new Color(0, 0, 0);
        points = 0;
    }

    void Update()
    {
        gColl = DetectCollG.CheckGColl();
        hColl = DetectCollH.CheckHColl();
        jColl = DetectCollJ.CheckJColl();

        if(points < 0)
        {
            points = 0;
        }

        if (Input.GetButton("g"))
        {
            personagem.transform.position = new Vector3(-4.4f, -3.34f, 0);
            buttons[0].GetComponent<Renderer>().material.SetColor("_Color", pressedNote);
            gValue = true;
            if(gColl == true)
            {
                Destroy(DetectCollG.gNote());
                ++points;
                particleG.Play();
            }
        }
        else
        {
            buttons[0].GetComponent<Renderer>().material.SetColor("_Color", normalNote);
            gValue = false;
        }

        if (Input.GetButton("h"))
        {
            personagem.transform.position = new Vector3(1.69f, -3.34f, 0);
            buttons[1].GetComponent<Renderer>().material.SetColor("_Color", pressedNote);
            hValue = true;
            if (hColl == true)
            {
                Destroy(DetectCollH.hNote());
                ++points;
                particleH.Play();
            }
        }
        else
        {
            buttons[1].GetComponent<Renderer>().material.SetColor("_Color", normalNote);
            hValue = false;
        }

        if (Input.GetButton("j"))
        {
            personagem.transform.position = new Vector3(7.62f, -3.34f, 0);
            buttons[2].GetComponent<Renderer>().material.SetColor("_Color", pressedNote);
            jValue = true;
            if (jColl == true)
            {
                Destroy(DetectCollJ.jNote());
                ++points;
                particleJ.Play();
            }
        }
        else
        {
            buttons[2].GetComponent<Renderer>().material.SetColor("_Color", normalNote);
            jValue = false;
        }
        pointsText.text = points.ToString("0");
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
    public static void lossPoints()
    {
        --points;
    }
}
