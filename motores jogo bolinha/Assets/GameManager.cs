using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI hud, msgViotria;
    public int restantes;
    
    
    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectsOfType < moeda >().Length;

        hud.text = $"Moedas restantes: {restantes} ";
    }

    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;
        hud.text = $"Moedas restantes: {restantes} ";

        if (restantes <= 0)
        {
            msgViotria.text = "parabens!";
        }
        
    }
}