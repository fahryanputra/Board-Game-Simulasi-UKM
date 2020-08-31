using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dieScript : MonoBehaviour {

	public Sprite[] dieSides;
	public SpriteRenderer dieButton;
	public Sprite dieButtonInactive;
	public Sprite dieButtonActive;

	private SpriteRenderer render;

	// Use this for initialization
	void Start () {
		render = GetComponent<SpriteRenderer> ();
		// dieSides = Resources.LoadAll<Sprite> ("Sprites/DieSides/");
		// render.sprite = dieSides [6];
	}
		
	private void OnMouseDown() {
		if (gameController.dieRollAllowed) {
			// Debug.Log ("clicked");
			StartCoroutine ("DieRoll");
			StartCoroutine ("ButtonPress");
		}
	}

	private IEnumerator DieRoll() {
		gameController.dieRollAllowed = false;

		int randomDieNumber = 0;

		for (int i = 0; i <= 20; i++) {
			randomDieNumber = Random.Range (0, 5);
			render.sprite = dieSides [randomDieNumber];
			yield return new WaitForSeconds (0.05f);
		}

		gameController.dieNumber = randomDieNumber + 1;
		Debug.Log ("You roll: " + gameController.dieNumber);
		gameController.MovePlayer ();

		gameController.dieRollAllowed = true;
	}

	private IEnumerator ButtonPress() {
		dieButton.sprite = dieButtonActive;
		yield return new WaitForSeconds (0.15f);
		dieButton.sprite = dieButtonInactive;
	}
}
