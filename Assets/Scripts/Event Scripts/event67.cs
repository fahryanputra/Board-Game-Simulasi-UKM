using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event67 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.creativity, 1);
		rollSquare85 = gameController.dieNumber;

		eventDesc = ("Survey lokasi cabang");
		eventOutcome = ("Kreatifitas: +1");
		SetEventMenuText ();
	}
}
