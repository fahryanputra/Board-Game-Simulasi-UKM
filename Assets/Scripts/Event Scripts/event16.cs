using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event16 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.quality, 1);

		eventDesc = ("Hire karyawan");
		eventOutcome = ("Kualitas: +1");
		SetEventMenuText ();
	}
}
