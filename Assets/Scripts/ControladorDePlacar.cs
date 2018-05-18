using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorDePlacar : MonoBehaviour {

    int placar = 0;
    public Text placarUI;


    // Use this for initialization
	void Start () {

        placar = 0;
        placarUI.text = "Placar: " + placar.ToString();
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void incrementaPlacar() {

        placar++;
        Debug.Log("Acertei um inimigo");
        placarUI.text = "Placar: " + placar.ToString();

    }
}
