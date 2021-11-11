using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAUSE : MonoBehaviour
{
    void PauseGame()
    {
        Time.timeScale = 0;
    }
}
