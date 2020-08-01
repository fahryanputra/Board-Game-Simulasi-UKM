using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event10 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.cash, 5000000);

		eventDesc = ("Beli alat operasional");
		eventOutcome = ("Uang: -5000000");
		SetEventMenuText ();
		Debug.Log (eventDesc);
	}
}
