using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCarta : MonoBehaviour {
    public static bool bCartaCreada = false;
    // Use this for initialization
    void Start () {
        
    }
	
	/*void Update () {
		
	}*/

    public static void GenerarCarta()
    {
        if (!bCartaCreada) { 
            GameObject carta = GameObject.CreatePrimitive(PrimitiveType.Cube);
            carta.transform.localScale = new Vector3(0.18f, 0.05f, 0.15f);
            carta.transform.position = new Vector3(0f, 5f, 0f);
            carta.AddComponent<Rigidbody>();
            bCartaCreada = true;
        }
    }
}
