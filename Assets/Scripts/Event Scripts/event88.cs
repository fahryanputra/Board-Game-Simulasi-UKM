using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event88 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.quality, 1);

		eventDesc = ("Integrasi sistem");
		eventOutcome = ("Kualitas: +1");
		SetEventMenuText ();
	}
}
