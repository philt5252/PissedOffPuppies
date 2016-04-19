using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	//int lastrow;
	int currentrow;

	public Vector3[] rowX;


	// Use this for initialization
	void Start () {
		currentrow = 0;
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 0; i >= 2; i++){
			rowX [i].y = transform.position.y;
			rowX [i].z = transform.position.z;
		}
		if (Input.GetButtonDown ("Left")) {
			if (currentrow != -1) {
				currentrow--;
				NewPosition (currentrow);
			}
		}
		if (Input.GetButtonDown ("Right")) {
			if (currentrow != 1) {
				currentrow++;
				NewPosition (currentrow);
			}
		}


	}
	void NewPosition(int row){
		if (row == -1) {
			transform.position = rowX[0];
		}
		if (row == 0) {
			transform.position = rowX[1];
		}
		if (row == 1) {
			transform.position = rowX[2];
		}
	}
		
}
