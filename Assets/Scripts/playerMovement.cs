using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	public float moveSpeed = 1f;

	// Use this for initialization
	void Start () {
		// Debug.Log ("there are " + boardSquares.Length + " squares");
		transform.position = gameController.boardSquares [gameController.boardSquaresIndex].transform.position;
	}
	
	// Update is called once per frame
	void Update () { 
		if (gameController.allowPlayerMovement == true) {
			Move ();
		}
	}

	void Move () {
		gameController.dieRollAllowed = false;

		if (gameController.boardSquaresIndex <= gameController.boardSquares.Length - 1) {
			transform.position = Vector2.MoveTowards (transform.position, gameController.boardSquares [gameController.boardSquaresIndex].transform.position, moveSpeed * Time.deltaTime);

			if (transform.position == gameController.boardSquares [gameController.boardSquaresIndex].transform.position) {
				gameController.boardSquaresIndex += 1;
			}
		}
	}
}
