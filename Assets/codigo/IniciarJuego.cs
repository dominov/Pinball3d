using UnityEngine;
using System.Collections;

public class IniciarJuego : MonoBehaviour {

	public SiguienteNivel sN;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftControl)) {
			sN.ActivarCarga ();
		}
	}
}
