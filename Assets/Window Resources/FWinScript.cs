﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FWinScript : MonoBehaviour {
	public Text titleText, goldText, expText, levelText, expCurrentText;
	public GameObject controlObj;
	public Control_Script cScript;
	public Button redoButton, mainButton;

	void Start () {
		controlObj = Control_Script.controlObj;
		cScript = controlObj.GetComponent<Control_Script>();

		cScript.goldAddText = goldText;
		cScript.expAddText = expText;
		cScript.levelCurrentText = levelText;
		cScript.expCurrentText = expCurrentText;
		cScript.feedbackTitleText = titleText;

		cScript.redoButton = redoButton;
		cScript.mainButton = mainButton;

		redoButton.onClick.AddListener(() => cScript.RedoButton());
		mainButton.onClick.AddListener(() => cScript.MainButton());
	}
}