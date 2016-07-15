using UnityEngine;
using System.Collections;

public class CtrSuelo : MonoBehaviour {

	public Vidas vidas;
	public CtrBarra ctrBarra;
	public CtrPelota ctrPelota;
	public GameObject agua;
	public GameObject pelota;
	// Use this for initialization
	void OnTriggerEnter(){
		


		Instantiate(agua, pelota.transform.position, Quaternion.identity);
		vidas.RestarVida();
	}
}
