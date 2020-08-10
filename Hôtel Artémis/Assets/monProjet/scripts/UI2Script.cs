using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI2Script : MonoBehaviour {
	
	public GameObject startMenuButton;


	// Update is called once per frame
	void Update () {
		
	}

	public void PauseGame () {
		
		startMenuButton.SetActive (true);
	}
}
