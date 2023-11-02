using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; //liber�a para gestionar audio

public class MenuOpciones : MonoBehaviour
{
    //Referencia al AudioMixer
    [SerializeField] private AudioMixer audioMixer;

    //Cambia el tama�o de la pantalla del juego
    public void PantallaCompleta(bool completa)
    {
        Screen.fullScreen = completa;
    }

    public void ElegirVolumen(float volumen)
    {
        audioMixer.SetFloat("Volumen", volumen);
    }
}
