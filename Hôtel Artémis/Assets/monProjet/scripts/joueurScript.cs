using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using TMPro;

public class joueurScript : MonoBehaviour {

	/*NavMeshAgent agent;
	public GameObject scoreObject;
	public int scoreValue;*/


	// Use this for initialization
	void Start () {
		/*agent = GetComponent<NavMeshAgent> ();
		scoreValue = 0;*/
		
	}

	// Update is called once per frame
	void Update () {
		/*	if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast (ray, out hit, Mathf.Infinity)) {
				agent.SetDestination(hit.point);
			}
		}

		if (Input.GetAxis ("Mouse X") > 0) {
			gameObject.transform.Rotate (0, -10f,0);
		}

		if (Input.GetAxis ("Mouse X") < 0) {
			gameObject.transform.Rotate (0, +10f,0);
		}*/
	}

	/*void OnTriggerExit (Collider other){
		if (other.tag == "ia"){
			scoreValue = scoreValue + 5;
			scoreObject.GetComponent<TextMeshProUGUI> ().text = scoreValue.ToString ();
		
		}
	}*/

}
