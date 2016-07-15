using UnityEngine;
using System.Collections;

public class CtrBarra : MonoBehaviour {
	public float velocidad; 
	private Vector3 posicionInicial;
	// Use this for initialization
	void Start () {
		posicionInicial = this.transform.position;
	}

	public void ReiniciarPos(){
		this.transform.position =  this.posicionInicial;
	}
	// Update is called once per frame
	void Update () {
		float tecladoHorizontal = Input.GetAxisRaw ("Horizontal");
		float posX = this.transform.position.x + (tecladoHorizontal * velocidad * Time.deltaTime);

		this.transform.position = new Vector3 (Mathf.Clamp( posX,-8,8), this.transform.position.y, this.transform.position.z);
	}
}
