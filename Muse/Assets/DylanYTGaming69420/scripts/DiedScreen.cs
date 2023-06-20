using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DiedScreen : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene("Prototype");
    }
}
