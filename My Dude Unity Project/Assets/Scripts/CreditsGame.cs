using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class CreditsGame : UnityEngine.MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Credits");
    }
}
