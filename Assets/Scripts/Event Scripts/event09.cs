using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event09 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.communication, 1);

		eventDesc = ("Ikut acara RW");
		eventOutcome = ("Komunikasi: +1");
		SetEventMenuText ();
		Debug.Log (eventDesc);
	}
}
