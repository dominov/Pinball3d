using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Vidas : MonoBehaviour {
	public static int numero = 4;
	public Text textVidas;

	public CtrBarra ctrBarra;
	public CtrPelota ctrPelota;
	public  GameObject gameOver;
	public SiguienteNivel siguienteNivel;

	// Use this for initialization
	void Start () {
		ActualizarVida ();
	}
	
	public void RestarVida(){
		if (Vidas.numero <= 0) {
			return;
		}
		Vidas.numero--;
		ActualizarVida ();
		if (Vidas.numero > 0) {
			
			ctrBarra.ReiniciarPos ();
			ctrPelota.ReiniciarPos ();
		} else {
			gameOver.SetActive (true);
			//ctrPelota.DetenerVelocidad ();
			ctrBarra.enabled = false;
			siguienteNivel.nivelACargar="portada";
			siguienteNivel.ActivarCarga ();
		}
	}

	public void ActualizarVida(){
		textVidas.text = "Vidas: " + numero;
	}
}