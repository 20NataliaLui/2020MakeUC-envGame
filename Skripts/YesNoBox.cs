using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class YesNoBox : MonoBehaviour
{

    //call Level Designer Go To Screen
    public void yes()
    {
        SceneManager.LoadScene("BedTime");
    }

    public void activate()
    {
        this.gameObject.SetActive(true);
    }

    //No just Disappear
   public void no()
    {
        this.gameObject.SetActive(false);
    }
}
