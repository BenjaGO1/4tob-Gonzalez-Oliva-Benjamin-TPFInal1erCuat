﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private void Comienzo()
    {
        SceneManager.LoadScene("Juego");
    }
}
