using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event43 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.cash, 5000000);
		AddValue (ref stat.quality, 1);

		eventDesc = ("Training teknologi ke karyawan");
		eventOutcome = ("Uang: -5000000, Kualitas: +1");
		SetEventMenuText ();
	}
}
