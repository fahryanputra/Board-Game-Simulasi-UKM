using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event11 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.communication, 1);

		eventDesc = ("Survey vendor");
		eventOutcome = ("Komunikasi: +1");
		SetEventMenuText ();
		Debug.Log (eventDesc);
	}
}
