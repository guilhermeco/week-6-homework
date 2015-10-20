using UnityEngine;
using System.Collections;

public class rayLaser : MonoBehaviour {

	public float rayDistance = 3;
	
	void Start () {
	
	}

	void Update () {

		RaycastHit hitInfo;
		if (Physics.Raycast (transform.position, transform.forward, out hitInfo, rayDistance) && hitInfo.transform.tag == "Goals") {
		Debug.Log ("hit it babes");
			Application.LoadLevel("Final");

		}
	
	}
	void OnDrawGizmos() {
		Gizmos.color = Color.red;
		Gizmos.DrawRay (transform.position, transform.forward * rayDistance);
	}



}
