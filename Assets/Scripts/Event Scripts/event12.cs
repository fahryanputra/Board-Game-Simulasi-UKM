using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event12 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.quality, 1);

		eventDesc = ("Jasa arsitek dan desain");
		eventOutcome = ("Kualitas: +1");
		SetEventMenuText ();
		Debug.Log (eventDesc);
	}
}
