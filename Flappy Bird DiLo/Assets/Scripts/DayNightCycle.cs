using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour {

	[SerializeField] private Bird bird;
	[SerializeField] private GameObject background1, background2, background3;
	[SerializeField] private SpriteRenderer dayRef, nightRef;
	[SerializeField] private float delayTime = 10f;

	private SpriteRenderer bg1, bg2, bg3;

	void Awake ()
	{
		bg1 = background1.GetComponent <SpriteRenderer> ();
		bg2 = background2.GetComponent <SpriteRenderer> ();
		bg3 = background3.GetComponent <SpriteRenderer> ();
	}
	
	void Start ()
	{
		StartCoroutine (DelayCycle ());
	}

	private IEnumerator DelayCycle ()
	{
		while (true)
		{
			IsDay ();
			yield return new WaitForSeconds(delayTime);
			IsNight ();
			yield return new WaitForSeconds(delayTime);
		}
	}

	private void IsDay ()
	{
		bg1.sprite = dayRef.sprite;
		bg2.sprite = dayRef.sprite;
		bg3.sprite = dayRef.sprite;
	} 

	private void IsNight ()
	{
		bg1.sprite = nightRef.sprite;
		bg2.sprite = nightRef.sprite;
		bg3.sprite = nightRef.sprite;
	}
}
