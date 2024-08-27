using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector3 = UnityEngine.Vector3;


public class PLAYER : MonoBehaviour
{
    public int velocidade = 10;
    public int ForcaPulo = 7;
    public bool noChao;
    public Rigidbody rb;

    void Start()
    {
        Debug.Log("Start!");
        TryGetComponent(out rb);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!noChao && collision.gameObject.tag == "Chão")
        {
            noChao = true;
        }
    }
    void Update()
    {
        Debug.Log("Update");
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        UnityEngine.Vector3 direcao = new Vector3(x, 0, y);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);

        if (Input.GetKeyDown(KeyCode.Space) && noChao)
        {
            rb.AddForce(Vector3.up * ForcaPulo, ForceMode.Impulse);
            noChao = false;
        }
        
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
