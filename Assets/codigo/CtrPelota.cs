using UnityEngine;
using System.Collections;

public class CtrPelota : MonoBehaviour {


	public Rigidbody rb;// se inicaliza desde el inspiector 
	public float velocidad;
	public Transform barra;


	bool enJuego;
	Vector3 posicionInicial;



	// Use this for initialization
	void Start () {
		posicionInicial = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!enJuego && Input.GetButtonDown ("Fire1")) {
			enJuego = true;
			this.transform.SetParent (null);
			this.rb.isKinematic = false;
			this.rb.AddForce (new Vector3 (velocidad, velocidad, 0));
		}
	}

	public void ReiniciarPos(){
		this.transform.position =  this.posicionInicial;
		this.transform.SetParent (barra);
		enJuego = false;
		DetenerVelocidad ();
	}

	public void DetenerVelocidad(){
		this.rb.isKinematic = true;
		this.rb.velocity = Vector3.zero;
	}
}
