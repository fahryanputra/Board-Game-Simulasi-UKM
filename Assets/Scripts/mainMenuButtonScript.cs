using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenuButtonScript : MonoBehaviour {

	public void PlayButton () {
		SceneManager.LoadScene ("stat allocation");
	}

	public void OptionButton () {
		Debug.Log ("Show Option");
	}

	public void QuitButton () {
		Application.Quit ();
		Debug.Log ("Application quit");
	}
}
