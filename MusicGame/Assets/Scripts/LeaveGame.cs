using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveGame : MonoBehaviour
{
    public void Return()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
