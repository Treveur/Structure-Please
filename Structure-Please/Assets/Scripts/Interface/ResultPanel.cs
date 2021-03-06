﻿using UnityEngine;
using System.Collections;

public class ResultPanel : MonoBehaviour {
	public IdentityCardPanel identityCardPanel;

	public void displayIDCard(Character character)
	{
		Debug.Log("ResultPanel::onPressIDCard("+character+")");
		if(!identityCardPanel.gameObject.activeInHierarchy)
		{
			identityCardPanel.gameObject.SetActive(true);
			identityCardPanel.displayCrystal(character);
		}
		else
		{
			displayIDCard();
		}
	}

	public void displayIDCard()
	{
		Debug.Log("ResultPanel::onPressIDCard()");
		identityCardPanel.gameObject.SetActive(false);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
