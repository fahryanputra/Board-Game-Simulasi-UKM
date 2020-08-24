using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenuButtonScript : MonoBehaviour {

	private Animator animator;
	private float animSpeed;

	public GameObject tutorialMenu;
	public Animator transitionAnim;
	public float transitionSpeed = 1f;

	void Awake () {
		animator = tutorialMenu.GetComponent<Animator> ();
		animSpeed = 0.25f;
	}
		
	public void OptionButton () {
		Debug.Log ("Show Option");
	}

	public void QuitButton () {
		Application.Quit ();
		Debug.Log ("Application quit");
	}

	public void TutorialButton () {
		tutorialMenu.SetActive (true);
	}

	public void OkButton () {
		StartCoroutine ("TutorialAnim");
	}

	private IEnumerator TutorialAnim () {
		animator.SetTrigger ("exit");
		yield return new WaitForSeconds (animSpeed);
		tutorialMenu.SetActive (false);
	}
}
