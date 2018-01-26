﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainMenuController : MonoBehaviour {

    public GameObject MainMenu;
    public GameObject PlayerSelectMenu;

    public Button playButton;

    void Start()
    {
        Button btn = playButton.GetComponent<Button>();
        btn.onClick.AddListener(OnPlayButtonClick);
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void deactivateAllMenu()
    {
        MainMenu.SetActive(false);
        PlayerSelectMenu.SetActive(false);
    }

    public void OnPlayButtonClick()
    {
        deactivateAllMenu();
        PlayerSelectMenu.SetActive(true);
    }

    public void OnExitButtonClick()
    {
        Application.Quit();
    }

    public void OnMainMenuButtonClick()
    {
        deactivateAllMenu();
        MainMenu.SetActive(true);
    }
}
