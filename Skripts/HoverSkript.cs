using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoverSkript : MonoBehaviour
{

    public string nextScene;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowMenu()
    {
        this.gameObject.SetActive(true);
    }

    public void close()
    {
        this.gameObject.SetActive(false);
    }

    public void gotoNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}

