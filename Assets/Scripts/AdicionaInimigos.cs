using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdicionaInimigos : MonoBehaviour {

    float tempo;

    float tempoPAdd = 5.0f;

    public GameObject inimigoPrefab;

    public GameObject playerPrefab;

    // Use this for initialization
    void Start()
    {

        Destroy(GameObject.FindGameObjectWithTag("inimigo"));

        Destroy(GameObject.FindGameObjectWithTag("Player"));

        Destroy(GameObject.FindGameObjectWithTag("projetil"));

        GameObject go = Instantiate(playerPrefab) as GameObject;
        go.transform.position = this.gameObject.transform.position;
        go.transform.rotation = this.gameObject.transform.rotation;


        tempo = Time.time;

    }
	
	// Update is called once per frame
	void Update () {

        if (Time.time - tempo >= tempoPAdd){
            GameObject go = Instantiate(inimigoPrefab) as GameObject;
            go.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
            go.transform.rotation = GameObject.FindGameObjectWithTag("Player").transform.rotation;
            go.transform.Translate(go.gameObject.transform.worldToLocalMatrix.MultiplyVector(go.gameObject.transform.forward) * 10.0f);
            tempo = Time.time;
        }



		
	}
}
