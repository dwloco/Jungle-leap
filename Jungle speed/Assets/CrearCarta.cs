using Leap.Unity.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCarta : MonoBehaviour {
    private InteractionBehaviour _intObj;
    public static bool bCartaCreada = false;

    //[Tooltip("If enabled, the object will use its primaryHoverColor when the primary hover of an InteractionHand.")]
    //public bool usePrimaryHover = false;

    // Use this for initialization
    void Start () {
        _intObj = GetComponent<InteractionBehaviour>();
    }

    void Update () {
        Debug.Log("isPrimaryHovered: " + _intObj.isPrimaryHovered);
        //Debug.Log("usePrimaryHover: " + usePrimaryHover);
        if (_intObj.isPrimaryHovered)
        {
            GenerarCarta(); //NUESTRO: Llama al metodo GenerarCarta de la clase CrearCarta
        }
    }

    public static void GenerarCarta()
    {
        if (!bCartaCreada) {
            //GameObject carta = GameObject.CreatePrimitive(PrimitiveType.Cube);
            //carta.transform.localScale = new Vector3(0.18f, 0.05f, 0.15f);
            //carta.transform.position = new Vector3(0f, 5f, 0f);
            //carta.AddComponent<Rigidbody>();
            Carta cartita = new Carta(0f, 5f, 0f);
            bCartaCreada = true;
        }
    }
}
