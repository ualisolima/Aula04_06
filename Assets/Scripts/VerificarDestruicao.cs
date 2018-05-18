using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificarDestruicao : MonoBehaviour {

    float tempo; //há quanto tempo o objeto existe
    float tempoDeVida = 3.0f; // qual o tamanho da vida do objeto
    // Use this for initialization
	void Start () {
        tempo = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time - tempo > tempoDeVida) {
            Destroy(this.gameObject);
        }
	}
}
