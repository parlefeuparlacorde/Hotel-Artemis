using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI3Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//jouer
	public void jouer () {
		SceneManager.LoadScene ("Niveau 2");
	}

	//quitter
	public void quitter () {
		Application.Quit ();
	}
}
