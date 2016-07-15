using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Puntos : MonoBehaviour {

	public static int numero = 0;
	public Text text;
	public SiguienteNivel siguienteNivel;
	public GameObject finishNivel,finishGame;
	public CtrBarra ctrBarra;
	public Transform bloques_;
	public CtrPelota ctrPelota;
	public FinalDePartida finalDePartida;
	// Use this for initialization
	void Start () {
		ActualizarTexto ();
	}

	public void ActualizarNumero(){
		Puntos.numero++;
		ActualizarTexto ();
		Debug.Log (bloques_.childCount);
		if(bloques_.childCount<=0){
			//nivel terminado

			finalDePartida.NivelCompleto ();
			ctrPelota.DetenerVelocidad ();
			ctrBarra.enabled = false;
			if (siguienteNivel.UltimoNivel ()) {
				
				finishGame.SetActive (true);
			} else {
				finishNivel.SetActive (true);
			}
			siguienteNivel.ActivarCarga ();

		}
	}

	public void ActualizarTexto(){
		text.text = "Puntos: " + numero;

	}
}
