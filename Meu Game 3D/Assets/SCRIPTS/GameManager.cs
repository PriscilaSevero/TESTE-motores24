using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI HUD, msgVitoria;
    public int restantes;
    public AudioClip clipMoeda, clipVitoria;

    private AudioSource source;
    void Start()
    {
        TryGetComponent(out source);
        
        restantes = FindObjectsOfType<Moeda>().Length;

        HUD.text = $"Moedas Restantes: {restantes}";
    }

    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;
        HUD.text = $"Moedas Restantes: {restantes}";
        source.PlayOneShot(clipMoeda);
        
        if (restantes <= 0)
        {
            //GANHOU JOGO!
            msgVitoria.text = "PARABÉNS!";
            source.Stop();
            source.PlayOneShot(clipVitoria);
        }
    }
    
    void Update()
    {
        
    }
}
