using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour {
	
	public Animator transitionAnim;
	public float transitionSpeed = 1f;

	public void LoadNextLevel () {
		StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
	}

	IEnumerator LoadLevel (int levelIndex) {
		if (levelIndex > 2) {
			levelIndex = 0;
		}
		transitionAnim.SetTrigger ("startTransition");
		yield return new WaitForSeconds (transitionSpeed);
		SceneManager.LoadScene (levelIndex);
	}
}
