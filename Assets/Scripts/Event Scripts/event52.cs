using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event52 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.cash, 6500000);
		AddValue (ref stat.quality, 1);

		eventDesc = ("Training karyawan");
		eventOutcome = ("Uang: -6500000, Kualitas: +1");
		SetEventMenuText ();
	}
}
