﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            pauseMenu.SetActive(true);
        }
    }
}
