using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dificuldade : MonoBehaviour
{
    [SerializeField] private Text txtDificuldade;
    [SerializeField] private Text txtSom;
    [SerializeField] private Slider sliderDificuldade;
    [SerializeField] private Slider sliderSom;
    public static float valorDificuldade;
    public static float valorSom;

    void Start()
    {
        sliderDificuldade.value = valorDificuldade;
        sliderSom.value = valorSom;
    }

    void Update()
    {
        if(sliderDificuldade.value == 1)
        {
            txtDificuldade.text = "EASY";
        }

        if (sliderDificuldade.value == 2)
        {
            txtDificuldade.text = "MEDIUM";
        }

        if (sliderDificuldade.value == 3)
        {
            txtDificuldade.text = "HARD";
        }

        if (sliderSom.value == 1)
        {
            txtSom.text = "LOW";
        }

        if (sliderSom.value == 2)
        {
            txtSom.text = "MEDIUM";
        }

        if (sliderSom.value == 3)
        {
            txtSom.text = "HIGH";
        }
        valorDificuldade = sliderDificuldade.value;
        valorSom = sliderSom.value;
    }

    public static float returnDificuldade()
    {
        return valorDificuldade;
    }

    public static float returnSom()
    {
        return valorSom;
    }
}
