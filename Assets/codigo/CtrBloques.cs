using UnityEngine;
using System.Collections;

public class CtrBloques : MonoBehaviour {

	public GameObject particula;
	public Puntos puntos;

	void OnCollisionEnter(){
		Instantiate (particula, this.transform.position, Quaternion.identity);

		this.transform.SetParent (null);
		if (this.gameObject != null) {
			Destroy (this.gameObject);
		}
		puntos.ActualizarNumero ();
	}

}
