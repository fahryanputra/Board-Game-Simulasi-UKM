﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event47 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.cash, 10000000);
		AddValue (ref stat.quality, 1);

		eventDesc = ("Upgrade usaha");
		eventOutcome = ("Uang: -10000000, Kualitas: +1");
		SetEventMenuText ();
	}
}
