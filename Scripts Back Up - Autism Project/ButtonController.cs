﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick() {
        var btnName = gameObject.GetComponentInChildren<Text>().text;
        if(btnName == "Manual")
            SceneManager.LoadScene("Manual");
        if (btnName == "Animation")
            SceneManager.LoadScene("Animation");
    }
}
