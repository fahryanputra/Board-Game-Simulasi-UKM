using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerStats : MonoBehaviour {

	public int cash;
	public int quality;
	public int creativity;
	public int communication;
	public int intelligence;
	public bool businessLicense = false;

	public Text cashText;
	public Text creativityText;
	public Text communicationText;
	public Text intelligenceText;
	public Text qualityText;

	public Text cashWinText;
	public Text creativityWinText;
	public Text communicationWinText;
	public Text intelligenceWinText;
	public Text qualityWinText;

	void Start () {
		creativity = statAllocation.creativityStat;
		communication = statAllocation.communicationStat;
		intelligence = statAllocation.intelligenceStat;
	}

	void Update () {
		cashText.text = "Rp " + cash.ToString ();
		creativityText.text = creativity.ToString ();
		communicationText.text = communication.ToString ();
		intelligenceText.text = intelligence.ToString ();
		qualityText.text = quality.ToString ();

		cashWinText.text = "Rp " + cash.ToString ();
		creativityWinText.text = creativity.ToString ();
		communicationWinText.text = communication.ToString ();
		intelligenceWinText.text = intelligence.ToString ();
		qualityWinText.text = quality.ToString ();
	}
}
