using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI1Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//startMenuButton
	public void startMenu () {
		SceneManager.LoadScene ("Niveau 3_menu");
	}
}
