﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FWinScript : MonoBehaviour {
	public Text titleText, goldText, expText, levelText, expCurrentText;
	private GameObject controlObj;
	private Control_Script cScript;
	public Button redoButton, mainButton;
	public Button toMainButton;
	public Button adButton;

	void Start () {
		controlObj = Control_Script.controlObj;
		cScript = controlObj.GetComponent<Control_Script>();

		cScript.goldAddText = goldText;
		cScript.expAddText = expText;
		cScript.levelCurrentText = levelText;
		cScript.expCurrentText = expCurrentText;
		cScript.feedbackTitleText = titleText;

		cScript.adButton = adButton;

		toMainButton.onClick.AddListener (() => cScript.SetActiveWindow (Control_Script.windows.NONE));

		adButton.onClick.AddListener (() => cScript.StartAdvertisement ());
		adButton.gameObject.SetActive (false);
		gameObject.SetActive (false);
	}
}
