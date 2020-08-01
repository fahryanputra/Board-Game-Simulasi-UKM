using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event61 : Event {

	public override void ActivateEvent() {
		if (stat.communication >= 5) {
			AddValue (ref stat.quality, 1);
			eventOutcome = ("Kualitas: +1");
		} else {
			eventOutcome = ("Tidak ada yang terjadi");
		}

		eventDesc = ("Membuat akun media sosial");
		SetEventMenuText ();
	}
}
