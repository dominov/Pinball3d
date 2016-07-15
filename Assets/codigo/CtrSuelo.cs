using UnityEngine;
using System.Collections;

public class CtrSuelo : MonoBehaviour {

	public Vidas vidas;
	public CtrBarra ctrBarra;
	public CtrPelota ctrPelota;
	public GameObject agua;
	public GameObject pelota;
	public AudioSource error;
	// Use this for initialization
	void OnTriggerEnter(){
		

		error.Play ();
		Instantiate(agua, pelota.transform.position, Quaternion.identity);
		vidas.RestarVida();
	}
}
