using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteClick : MonoBehaviour
{
    private enum ButtonState { G, H, J, WAITING };
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
    [SerializeField] private Text pointsText2;
    public ParticleSystem particleG;
    public ParticleSystem particleH;
    public ParticleSystem particleJ;

    [SerializeField] private GameObject personagem;
    //[SerializeField] private ParticleSystem hitParticles;

    private ButtonState state = ButtonState.WAITING;

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

        if(state == ButtonState.WAITING)
        {
            personagem.transform.position = new Vector3(9.18f, -3.34f, 0);
        }

        if(points < 0)
        {
            points = 0;
        }
        if (Input.GetButton("g"))
        {
            if (state == ButtonState.WAITING)
            {
                state = ButtonState.G;
                personagem.transform.position = new Vector3(-4.4f, -3.34f, 0);
                buttons[0].GetComponent<Renderer>().material.SetColor("_Color", pressedNote);
                gValue = true;
                if (gColl == true)
                {
                    Destroy(DetectCollG.gNote());
                    ++points;
                    particleG.Play();
                }
            }
        }
        else
        {
            state = ButtonState.WAITING;
            buttons[0].GetComponent<Renderer>().material.SetColor("_Color", normalNote);
            gValue = false;
        }

        if (Input.GetButton("h"))
        {
            if (state == ButtonState.WAITING)
            {
                state = ButtonState.H;
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
        }
        else
        {
            state = ButtonState.WAITING;
            buttons[1].GetComponent<Renderer>().material.SetColor("_Color", normalNote);
            hValue = false;
        }

        if (Input.GetButton("j"))
        {
            if (state == ButtonState.WAITING)
            {
                state = ButtonState.J;
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
        }
        else
        {
            state = ButtonState.WAITING;
            buttons[2].GetComponent<Renderer>().material.SetColor("_Color", normalNote);
            jValue = false;
        }
        pointsText.text = points.ToString("0");
        pointsText2.text = points.ToString("0");
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
