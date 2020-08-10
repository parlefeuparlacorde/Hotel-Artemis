using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ennemyIAScript : MonoBehaviour {

	NavMeshAgent agent;
	public GameObject player;
	bool interupteur;

	//HealthPoint
	public float BcurrentHP;
	public float BmaxHP = 100f;
	public float BcurrentBarLength;
	public float BmaxBarLength;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		interupteur = true;
		BcurrentHP = 100f;
	}

	// Update is called once per frame
	void Update () {
		//interupteur
		if (interupteur == true) {
			interupteurFunction ();
		}

		if (interupteur == false) {
			agent.SetDestination (gameObject.transform.position);
		}

		//Health Point
		if (GameObject.Find ("HealthPointObject").GetComponent<hpscript> ().currentHP < 0) {
			interupteur = false;
			gameObject.GetComponent<Animator> ().SetBool ("deathBool", true);
		}

		//HealthPointB
		BcurrentBarLength = BcurrentHP * BmaxBarLength / BmaxHP;
		GameObject.Find("joueurHealthPointA").GetComponent<RectTransform>().localScale = new Vector3 (BcurrentBarLength, 0.25f, 1f);
		if (BcurrentHP < 0) {
		GameObject.Find("joueurHealthPointA").GetComponent<RectTransform>().localScale = new Vector3 (0, 0.25f, 1f);
		}
	}

	void interupteurFunction (){
		agent.SetDestination (player.transform.position);
	}

	void OnTriggerStay (Collider other ){
		//hp joueur
		BcurrentHP -= 5;
	}

}
