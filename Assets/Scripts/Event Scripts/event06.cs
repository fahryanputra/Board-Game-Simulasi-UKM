using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event06 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.creativity, 1);

		eventDesc = ("Datang ke festival bekraf");
		eventOutcome = ("Kreatifitas: +1");
		SetEventMenuText ();
		Debug.Log (eventDesc);
	}
}
