using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event83 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.quality, 1);

		eventDesc = ("Diundang ikut festival bekraf");
		eventOutcome = ("Kualitas: +1");
		SetEventMenuText ();
	}
}
