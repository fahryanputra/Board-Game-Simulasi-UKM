﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event94 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.quality, 1);

		eventDesc = ("Ikut pameran");
		eventOutcome = ("Kualitas: +1");
		SetEventMenuText ();
	}
}