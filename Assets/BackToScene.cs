using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToScene : MonoBehaviour
{
    private void BackToGame()
    {
        SceneManager.LoadScene("Juego");
    }
}
