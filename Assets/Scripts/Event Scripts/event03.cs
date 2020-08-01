using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event03 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.intelligence, 1);

		eventDesc = ("Konsultasi Bisnis!");
		eventOutcome = ("Kecerdasan: +1");
		SetEventMenuText ();
		Debug.Log (eventDesc);
	}
}
