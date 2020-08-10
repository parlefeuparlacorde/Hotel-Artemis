using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI4Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<TextMeshProUGUI> ().text = ("DERNIER SCORE : ") + PlayerPrefs.GetInt("scoreValuePrefs").ToString();
	}
}
