using UnityEngine;
using System.Collections;

public class FinalDePartida : MonoBehaviour {

	public AudioSource audioSource;
	public AudioClip completado, gameOver;
	// Use this for initialization

	public void GameOver(){
		audioSource.clip = gameOver;
		audioSource.loop = false;
		audioSource.Play ();
	}
	public void NivelCompleto(){
		audioSource.clip = completado;
		audioSource.loop = false;
		audioSource.Play ();
	}
}
