using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilScript : MonoBehaviour {

	public GameObject projetoPrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			//atira
			GameObject go = Instantiate(projetoPrefab) as GameObject;
			go.transform.position = this.gameObject.transform.position;
			go.transform.rotation = this.gameObject.transform.rotation;
			go.transform.Translate (go.gameObject.transform.worldToLocalMatrix.MultiplyVector(go.gameObject.transform.forward) * 1.0f);
			go.GetComponent<Rigidbody> ().AddForce (go.transform.forward * 1000.0f);
		}
	}
}
