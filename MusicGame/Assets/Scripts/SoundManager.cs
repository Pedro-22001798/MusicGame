using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private float somAtual;
    [SerializeField] private AudioSource musica;
    private bool clicked;

    void Start()
    {
        clicked = MainMenu.returnOptionsClicked();
    }

    void Update()
    {
        if(clicked)
        {
            somAtual = Dificuldade.returnSom();
            musica.volume = ((somAtual / 5) - 0.15f);
        }
        else
        {
            musica.volume = 0.3f;
        }
    }
}
