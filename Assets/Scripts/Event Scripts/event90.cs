using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event90 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.quality, 1);

		eventDesc = ("Bad review viral");
		eventOutcome = ("Kualitas: -1");
		SetEventMenuText ();
	}
}
