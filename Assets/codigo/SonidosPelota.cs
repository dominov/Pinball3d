using UnityEngine;
using System.Collections;

public class SonidosPelota : MonoBehaviour {


	public AudioSource rebote, punto;

	void OnCollisionEnter( Collision otro){

		if (otro.gameObject.CompareTag ("bloque")) {
			punto.Play ();
		} else {
			rebote.Play ();
		}
		
	}
}
