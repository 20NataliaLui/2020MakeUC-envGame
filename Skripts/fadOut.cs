using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fadOut : MonoBehaviour
{
    public void goToEnd()
    {
        Debug.Log("End");
        SceneManager.LoadScene("EndScene");
    }
}
