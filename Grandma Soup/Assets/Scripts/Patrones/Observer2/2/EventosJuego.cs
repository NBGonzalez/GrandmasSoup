using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventosJuego : MonoBehaviour
{
    public delegate void RecogerVidaEventHandler();
    public static event RecogerVidaEventHandler OnRecogerVida;

    public static void NotificarRecogerVida()
    {
        OnRecogerVida?.Invoke();
    }
}
