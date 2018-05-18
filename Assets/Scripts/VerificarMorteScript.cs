using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificarMorteScript : MonoBehaviour {


    public float speed;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        float setp = speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position, setp);

		
	}

	private void OnCollisionEnter(Collision collision)
	{
        if(collision.gameObject.tag.Equals("projetil")) {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<ControladorDePlacar>().incrementaPlacar();
            Destroy (collision.gameObject);
            Destroy(this.gameObject);
        }
	}
}
