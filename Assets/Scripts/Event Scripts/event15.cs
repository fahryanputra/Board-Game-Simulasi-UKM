using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event15 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.quality, gameController.dieNumber);

		eventDesc = ("Observasi demand");
		eventOutcome = ("Kualitas: +" + gameController.dieNumber);
		SetEventMenuText ();
		Debug.Log (eventDesc);
	}
}
