using UnityEngine;
using System.Collections;

public class enemyMover4 : MonoBehaviour {

	private Transform startPoint, endPoint;
	
	public float percentage;
	public float speed = 5;
	public float rayDistance = 3;
	
	private int direction;
	
	void Start () {
		
		startPoint = GameObject.Find ("StartPoint4").transform;
		endPoint = GameObject.Find ("Player").transform;
		direction = 1;
		
	}
	
	
	void Update () {
		
		transform.LookAt(GameObject.Find ("Player").transform.position);
		
		transform.position = Vector3.Lerp (startPoint.position, endPoint.position, percentage);
		
		percentage += Time.deltaTime/speed * direction;

		RaycastHit hitInfo;
		if (Physics.Raycast (transform.position, transform.forward, out hitInfo, rayDistance)) {
			Invoke("loadLevel",1);
		}
		
		//	if ((percentage > 1) || (percentage < 0)) {
		//		
		//	}
		
	}

	void OnDrawGizmos() {
		Gizmos.color = Color.red;
		Gizmos.DrawRay (transform.position, transform.forward * rayDistance);
	}

	void loadLevel(){
		Application.LoadLevel("FPS");
	}
}
