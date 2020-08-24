using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelScript : MonoBehaviour {

	private int randomValue;
	private float timeInterval;
	private bool coroutineAllowed;

	// Use this for initialization
	void Start () {
		coroutineAllowed = true;
	}
	
	// Update is called once per frame
	private void OnMouseDown() {
		if (coroutineAllowed) {
			StartCoroutine (Spin ());
		}
	}

	private IEnumerator Spin () {
		coroutineAllowed = false;
		randomValue = Random.Range (40, 50);
		timeInterval = 0.05f;

		for (int i = 0; i < randomValue; i++) {
			transform.Rotate (0, 0, 22.5f);
			if (i > Mathf.RoundToInt (randomValue * 0.5f))
				timeInterval = 0.1f;
			if (i > Mathf.RoundToInt (randomValue * 0.85f))
				timeInterval = 0.2f;
			yield return new WaitForSeconds (timeInterval);
		}

		if (Mathf.RoundToInt (transform.eulerAngles.z) % 45 == 0)
			transform.Rotate (0, 0, 22.5f);

		coroutineAllowed = true;
	}
}
