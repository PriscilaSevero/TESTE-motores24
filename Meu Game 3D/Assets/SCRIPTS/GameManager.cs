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
        restantes = FindObjectOfType<Moeda>().Length;
    }

    
    void Update()
    {
        
    }
}
