using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class joueur2Script : MonoBehaviour {
	
	public GameObject scoreObject;
	public int scoreValue;
	public float vitessePositif;
	public float vitesseNegatif;

	public GameObject HealthPointObject;

	//object cheat code
	public GameObject camera1;
	public GameObject camera2;
	public GameObject cheatCodeGameObject;
	public GameObject hpBar1;
	public GameObject hpBar2;
	public GameObject victoire;
	public GameObject nouveauScore;
	public GameObject startMenuButton;

	// Use this for initialization
	void Start () {

		scoreValue = 0;
		PlayerPrefs.SetInt("scoreValuePrefs", scoreValue);
		PlayerPrefs.Save();
		//:D
		camera1.SetActive (true);
		camera2.SetActive (false);
		cheatCodeGameObject.SetActive (true);
		hpBar1.SetActive (true);
		hpBar2.SetActive (true);
		victoire.SetActive (false);
		nouveauScore.SetActive (false);
		startMenuButton.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
		/*//rotation
		if (Input.GetAxis ("Mouse X") > 0) {
			gameObject.transform.Rotate (0, -10f,0);
		}

		if (Input.GetAxis ("Mouse X") < 0) {
			gameObject.transform.Rotate (0, +10f,0);
		}

		//déplacement
		if (Input.GetAxis ("Horizontal") > 0) {
			gameObject.transform.Translate (vitessePositif, 0, 0);
		}

		if (Input.GetAxis ("Horizontal") < 0) {
			gameObject.transform.Translate (vitesseNegatif, 0, 0);
		}

		if (Input.GetAxis ("Vertical") > 0) {
			gameObject.transform.Translate (0, 0, vitessePositif);
		}

		if (Input.GetAxis ("Vertical") < 0) {
			gameObject.transform.Translate (0, 0, vitesseNegatif);
		}*/

		//déplacement 2
		if (Input.GetAxis ("Vertical") > 0 ) {
			gameObject.transform.Translate (0, 0, vitessePositif);
			gameObject.GetComponent<Animator>().SetBool("runBool", true);
		}

		if (Input.GetAxis ("Vertical") == 0 ) {
			gameObject.GetComponent<Animator>().SetBool("runBool", false);
		}

		if (Input.GetAxis ("Fire1") > 0 && Input.GetAxis ("Mouse X") > 0) {
			gameObject.transform.Rotate (0, -25f,0);
		}

		if (Input.GetAxis ("Fire1") > 0 && Input.GetAxis ("Mouse X") < 0) {
			gameObject.transform.Rotate (0, +25f,0);
		}

		cheatCode ();

	}

	void OnTriggerStay (Collider other){
		scoreValue = scoreValue + 75;
		scoreObject.GetComponent<TextMeshProUGUI> ().text = scoreValue.ToString ();
		//hp ia
		HealthPointObject.GetComponent<hpscript> ().currentHP -= 5;
	}

	/*enregistrement du score
	void SaveAllPrefs() {
		PlayerPrefs.SetInt("scoreValuePrefs", scoreValue);
		PlayerPrefs.Save();
	}*/

	//cheat code
	void cheatCode () {
		if (Input.GetKeyDown (KeyCode.X)) {
			camera1.SetActive (false);
			camera2.SetActive (true);
			cheatCodeGameObject.SetActive (false);
			hpBar1.SetActive (false);
			hpBar2.SetActive (false);
			victoire.SetActive (true);
			scoreObject.SetActive (false);
			nouveauScore.SetActive(true);
			startMenuButton.SetActive (true);
			PlayerPrefs.SetInt("scoreValuePrefs", scoreValue);
			nouveauScore.GetComponent<TextMeshProUGUI> ().text = PlayerPrefs.GetInt("scoreValuePrefs").ToString();
			PlayerPrefs.Save();
		}
	}

}
