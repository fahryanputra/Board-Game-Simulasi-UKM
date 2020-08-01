using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event86 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.quality, 1);

		eventDesc = ("Buat loyalty program");
		eventOutcome = ("Kualitas: +1");
		SetEventMenuText ();
	}
}
