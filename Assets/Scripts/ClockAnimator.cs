using UnityEngine;
using System;
//we need to get DateTime struct from System namespace
public class ClockAnimator:MonoBehaviour{
	
	private const float
	hoursToDegrees = 360f/12f,
	minutesToDegrees=360f/60f, //how many degrees per hour/minute/second
	secondsToDegrees=360f/60f;

	public Transform hours, minutes, seconds;

	public bool analog;

	private void Update()
	{
		if (analog) {
			TimeSpan timespan =DateTime.Now.TimeOfDay;
			hours.localRotation =
				Quaternion.Euler(0f, 0f, (float)timespan.TotalHours * -hoursToDegrees);
			minutes.localRotation=
				Quaternion.Euler(0f, 0f, (float)timespan.TotalMinutes* -minutesToDegrees);
			seconds.localRotation=
				Quaternion.Euler(0f,0f, (float)timespan.TotalSeconds * - secondsToDegrees);

		}
		DateTime time = DateTime.Now;
		//Quaternion represents the 3D rotation
		hours.localRotation =
			Quaternion.Euler(0f, 0f, time.Hour * -hoursToDegrees);
		minutes.localRotation=
			Quaternion.Euler(0f, 0f, time.Minute* -minutesToDegrees);
		seconds.localRotation=
			Quaternion.Euler(0f,0f, time.Second * - secondsToDegrees);		
	}
}