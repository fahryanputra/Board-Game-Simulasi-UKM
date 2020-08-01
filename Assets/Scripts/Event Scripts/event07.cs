using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event07 : Event {

	public override void ActivateEvent() {
		if (stat.communication >= 4) {
			AddValue (ref stat.cash, 2000000);
			eventOutcome = ("Uang: +2000000");
		} else {
			eventOutcome = ("Tidak ada yang terjadi");
		}

		eventDesc = ("Tambahan modal dari keluarga");
		SetEventMenuText ();
		Debug.Log (eventDesc);
	}
}
