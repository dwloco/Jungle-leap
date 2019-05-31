using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
    List<Carta> listaMazoTotal;
    Jugador[] jugadores = new Jugador[4];
    int iCantJugadores;
    int iIndexJugActual;

	// Use this for initialization
	void Start () {
        /* Aca en algun momento vamos a meter un menu 
         * para hostear partidas y elegir cant de jugadores
         */
        listaMazoTotal = new List<Carta>();
        //LlenarMazo();
        //RepartirMazo();
        iIndexJugActual = 0;
        //En el futuro eligiremos el jugador inicial de manera aleatoria
        //iIndexJugActual = ObtenerRandom(4);

	}

    private void RepartirMazo(int iCantJugadores = 4)
    {
        Mezclar(ref listaMazoTotal);
        Mezclar(ref listaMazoTotal);
        int listaIndex = 0;
        for (int i = 0; i < listaMazoTotal.Count/iCantJugadores; i++)
        {
            for (int j = 0; j < iCantJugadores; j++)
            {
                jugadores[j].AgregarCarta(listaMazoTotal[listaIndex]);
                listaIndex++;
            }
            
        }
    }

    private void Mezclar(ref List<Carta> listaMazoTotal)
    {
        for (int i = 0; i < listaMazoTotal.Count; i++)
        {
            Carta cAux = listaMazoTotal[i];
            int iRand = ObtenerRandom(listaMazoTotal.Count);
            listaMazoTotal[i] = listaMazoTotal[iRand];
            listaMazoTotal[iRand] = cAux;

        }
    }

    private void LlenarMazo()
    {
        throw new NotImplementedException();
    }

    private int ObtenerRandom(int iMax)
    {
        System.Random r = new System.Random();
        return r.Next(iMax);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
