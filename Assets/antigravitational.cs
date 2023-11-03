using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antigravitational : MonoBehaviour
{
    public GameObject jugador;
    private bool jugadorEnELCubo = false;
    private int coleccionablesRecolectados = 0; // Contador de coleccionables recolectados
    public int coleccionablesNecesarios = 4;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == jugador)
        {
            Rigidbody jugadorRB = jugador.GetComponent<Rigidbody>();
            jugadorRB.useGravity = false;
            jugadorEnELCubo = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == jugador)
        {
            Rigidbody jugadorRB = jugador.GetComponent<Rigidbody>();
            jugadorRB.useGravity = true;
            jugadorEnELCubo = false;
        }
    }

    public void RecolectarColeccionable()
    {
        coleccionablesRecolectados++;

        if (coleccionablesRecolectados >= coleccionablesNecesarios)
        {

        }
    }

    private void Update()
    {
        if (jugadorEnELCubo)
        {
            jugador.transform.position = transform.position;

            if (Input.GetKeyDown(KeyCode.E))
            {
                Rigidbody jugadorRB = jugador.GetComponent<Rigidbody>();
                jugadorRB.useGravity = true;
                jugadorEnELCubo = false;
            }
        }
    }
}