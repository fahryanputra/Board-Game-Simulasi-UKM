using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event54 : Event {

	public override void ActivateEvent() {
		if (stat.communication < 5) {
			RemoveValue (ref stat.quality, 1);
			eventOutcome = ("Kualitas: -1");
		} else {
			eventOutcome = ("Tidak ada yang terjadi");
		}

		eventDesc = ("Konflik antar karyawan");
		SetEventMenuText ();
	}
}
