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
	}
}
