using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoScript : MonoBehaviour {

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.GetComponent<Rigidbody>().freezeRotation = false;

		if (Input.GetKey (KeyCode.UpArrow)) {
            this.GetComponent<Rigidbody>().freezeRotation = true;
			this.gameObject.transform.Translate (this.gameObject.transform.worldToLocalMatrix.MultiplyVector(this.gameObject.transform.forward) * 0.1f);
		} else if (Input.GetKey (KeyCode.DownArrow)) {
            this.GetComponent<Rigidbody>().freezeRotation = true;
			this.gameObject.transform.Translate (this.gameObject.transform.worldToLocalMatrix.MultiplyVector(this.gameObject.transform.forward) * -0.1f);
		} else if (Input.GetKey (KeyCode.RightArrow)) {
            this.GetComponent<Rigidbody>().freezeRotation = true;
			this.gameObject.transform.RotateAround (this.gameObject.transform.position, Vector3.up, 1);
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
            this.GetComponent<Rigidbody>().freezeRotation = true;
			this.gameObject.transform.RotateAround (this.gameObject.transform.position, Vector3.up, -1);
        }
		
	}

	private void OnTriggerEnter(Collider other)
	{
        Debug.Log("encostou");
        GameObject[] inimigos = GameObject.FindGameObjectsWithTag("inimigo");
        for (int i = 0; i < inimigos.Length; i++) {
            inimigos[i].GetComponent<Renderer>().material.color = Color.gray;
        }
	}

}
