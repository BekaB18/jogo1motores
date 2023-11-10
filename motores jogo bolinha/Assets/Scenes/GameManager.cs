using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI hud, msgViotria;
    public int restantes;
    public AudioClip clipMoeda, clipVitoria;

    private AudioSource source;
    
    
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out source);
        restantes = FindObjectsOfType < moeda >().Length;

        hud.text = $"Moedas restantes: {restantes} ";
    }

    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;
        hud.text = $"Moedas restantes: {restantes} ";
        source.PlayOneShot(clipMoeda);

        if (restantes <= 0)
        {
            msgViotria.text = "Parabéns, você ganhou o jogo!";
            source.PlayOneShot(clipVitoria);
        }
        
    }
}
