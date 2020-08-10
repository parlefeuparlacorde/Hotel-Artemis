using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI5Script : MonoBehaviour {

	public GameObject logo;
	Color logoColor;
	public float lerpMultiplier = 0.02f;

	// Use this for initialization
	void Start () {
		logoColor = new Color (0, 0, 0, 1);
		logo.GetComponent<Image>().color = logoColor;

		StartCoroutine (GotoMainMenu ());
	}
	
	// Update is called once per frame
	void Update () {
		logoColor = Color.Lerp (logoColor, new Color (1, 1, 1, 1), Time.time * lerpMultiplier);
		logo.GetComponent<Image>().color = logoColor;

	}

	IEnumerator GotoMainMenu (){
		yield return new WaitForSeconds (4);
		SceneManager.LoadScene ("Niveau 3_menu");
	}
}
