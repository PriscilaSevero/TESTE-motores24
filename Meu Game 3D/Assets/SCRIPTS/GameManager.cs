using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI HUD, msgVitoria;
    public int restantes;
    
    void Start()
    {
        restantes = FindObjectsOfType<Moeda>().Length;

        HUD.text = $"Moedas Restantes: {restantes}";
    }

    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;
        HUD.text = $"Moedas Restantes: {restantes}";

        if (restantes <= 0)
        {
            //GANHOU JOGO!
            msgVitoria.text = "PARABÉNS!";
        }
    }
    
    void Update()
    {
        
    }
}
