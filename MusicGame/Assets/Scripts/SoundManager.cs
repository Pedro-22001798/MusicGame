using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private float somAtual;
    [SerializeField] private AudioSource musica;

    void Update()
    {
        somAtual = Dificuldade.returnSom();
        musica.volume = ((somAtual / 5 )-0.15f);
    }
}
