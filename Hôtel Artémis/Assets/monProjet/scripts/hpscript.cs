using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpscript : MonoBehaviour {
	public float currentHP;
	public float maxHP = 100f;
	public float currentBarLength;
	public float maxBarLength = 25f;

	// Use this for initialization
	void Start () {
		currentHP = 100f;
	}
	
	//Update is called once per frame
	void Update () {
		currentBarLength = currentHP * maxBarLength / maxHP;
		gameObject.transform.localScale = new Vector3 (4, 4, currentBarLength);

		if (currentHP < 0) {
			gameObject.transform.localScale = new Vector3 (0, 0, 0);
			GameObject.Find ("Pistol").GetComponent<ParticleSystem> ().Stop ();
		}
	}
}
