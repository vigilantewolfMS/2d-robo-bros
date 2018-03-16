using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetIfFall : MonoBehaviour {

	private Vector3 startpos;
	
	void Start(){
		startpos = transform.position;
	}
	
	void FixedUpdate(){
		if (transform.position.y < -15){
			transform.position = startpos;
		}
	}
}
