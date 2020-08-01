using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event28 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.quality, 1);

		eventDesc = ("Karyawan resign");
		eventOutcome = ("Kualitas: -1");
		SetEventMenuText ();
	}
}
