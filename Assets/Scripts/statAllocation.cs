using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class statAllocation : MonoBehaviour {

	public static int creativityStat = 0;
	public static int communicationStat = 0;
	public static int intelligenceStat = 0;

	public int statPoint = 10;

	public Text creativityStatText;
	public Text communicationStatText;
	public Text intelligenceStatText;
	public Text statPointText;

	public Button confirmButton;

	void Update () {
		creativityStatText.text = creativityStat.ToString ();
		communicationStatText.text = communicationStat.ToString ();
		intelligenceStatText.text = intelligenceStat.ToString ();
		statPointText.text = statPoint.ToString ();

		if (statPoint == 0) {
			confirmButton.interactable = true;
		} else {
			confirmButton.interactable = false;
		}
	}

	void AddStat (ref int statAdd) {
		if (statPoint > 0) {
			statAdd += 1;
			statPoint -= 1;
		} else {
			statAdd += 0;
		}
	}

	void RemoveStat (ref int statRemove) {
		if (statRemove > 0) {
			statRemove -= 1;
			statPoint += 1;
		} else {
			statPoint += 0;
		}
	}

	public void CreativityAdd () {
		AddStat (ref creativityStat);
	}

	public void CreativityRemove () {
		RemoveStat (ref creativityStat);
	}

	public void CommunicationAdd () {
		AddStat (ref communicationStat);
	}

	public void CommunicationRemove () {
		RemoveStat (ref communicationStat);
	}

	public void IntelligenceAdd () {
		AddStat (ref intelligenceStat);
	}

	public void IntelligenceRemove () {
		RemoveStat (ref intelligenceStat);
	}

	public void StatReset () {
		creativityStat = 0;
		communicationStat = 0;
		intelligenceStat = 0;
		statPoint = 10;
	}

	public void StatConfirm () {
		SceneManager.LoadScene ("game scene");
	}
}
