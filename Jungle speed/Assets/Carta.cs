using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta : MonoBehaviour {

    public GameObject objCarta;
    const float scaleX = 0.18f, scaleY = 0.05f, scaleZ = 0.15f;    

    public Carta(float x, float y, float z)
    {
        //Instantiate(objCarta, new Vector3(x, y, z), Quaternion.identity);
        objCarta = GameObject.CreatePrimitive(PrimitiveType.Cube);
        objCarta.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
        objCarta.transform.position = new Vector3(x, y, z);
        objCarta.AddComponent<Rigidbody>();
        objCarta.GetComponentInChildren<Renderer>().material.color = Color.red; //Cambiarlo por textura cuando Abril termine
    }
}
