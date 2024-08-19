using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;


public class PLAYER : MonoBehaviour
{
    public int velocidade = 10;
    public Rigidbody rb;

    void Start()
    {
        Debug.Log("Start!");
        TryGetComponent(out rb);
    }

    void Update()
    {
        Debug.Log("Update");
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        UnityEngine.Vector3 direcao = new Vector3(x, 0, y);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);
    }
}
