using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoProjetilScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (this.gameObject.transform.worldToLocalMatrix.MultiplyVector(this.gameObject.transform.forward) * 0.1f);
	}
}
