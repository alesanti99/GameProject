using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestoreMenu : MonoBehaviour
{
    public void AvviaClick()
    {
        SceneManager.LoadScene(1);
    }
}
