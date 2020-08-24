using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameUIButtonScript : MonoBehaviour {

	private Animator animator;
	private Text loanOutcomeText;
	private float animSpeed;

	protected playerStats stat;

	void Awake () {
		animator = GetComponent<Animator> ();
	}

	void Start () {
		loanOutcomeText = GameObject.Find ("Game Menu Controller").GetComponent<gameMenuController> ().outcomeText;
		stat = GameObject.Find ("Player").GetComponent<playerStats> ();
		animSpeed = animator.GetCurrentAnimatorStateInfo (0).length * (1 / animator.GetCurrentAnimatorStateInfo (0).speed);
		Debug.Log (animSpeed);
	}

	public void DismissEventUI () {
		StartCoroutine ("EventExit");
	}

	public void DismisChanceUI () {
		StartCoroutine ("ChanceExit");
	}

	public void DismissOutcomeUI () {
		StartCoroutine ("OutcomeExit");
	}

	public void DismissTakeLoanUI () {
		StartCoroutine ("LoanExit");
	}

	public void DismissWinUI () {
		StartCoroutine ("WinExit");
	}

	public void TakeLoan10 () {
		loanOutcomeText.text = ("Anda mengambil pinjaman sebesar Rp10.000.000");
		DismissTakeLoanUI ();
		stat.cash += 10000000;
		Debug.Log ("You take 10M Loan");
	}

	public void TakeLoan20 () {
		loanOutcomeText.text = ("Anda mengambil pinjaman sebesar Rp20.000.000");
		DismissTakeLoanUI ();
		stat.cash += 20000000;
		Debug.Log ("You take 20M Loan");
	}

	public void TakeLoan50 () {
		loanOutcomeText.text = ("Anda mengambil pinjaman sebesar Rp50.000.000");
		DismissTakeLoanUI ();
		stat.cash += 50000000;
		Debug.Log ("You take 50M Loan");
	}

	private IEnumerator EventExit () {
		animator.SetTrigger ("exit");
		yield return new WaitForSeconds (animSpeed);
		gameController.showEventUI = false;
		gameController.showOutcomeUI = true;
	}

	private IEnumerator OutcomeExit () {
		animator.SetTrigger ("exit");
		yield return new WaitForSeconds (animSpeed);
		gameController.showOutcomeUI = false;
		gameController.dieRollAllowed = true;
	}

	private IEnumerator ChanceExit () {
		animator.SetTrigger ("exit");
		yield return new WaitForSeconds (animSpeed);
		gameController.showChanceUI = false;
		gameController.showOutcomeUI = true;
	}

	private IEnumerator LoanExit () {
		animator.SetTrigger ("exit");
		yield return new WaitForSeconds (animSpeed);
		gameController.showTakeLoanUI = false;
		gameController.showOutcomeUI = true;
	}

	private IEnumerator WinExit () {
		animator.SetTrigger ("exit");
		yield return new WaitForSeconds (animSpeed);
		SceneManager.LoadScene ("main menu");
	}
}
