using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class replay : MonoBehaviour
{
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onReplay()
    {
        SceneManager.LoadScene(0);
    }
    public void onMainTrans()
    {
        SceneManager.LoadScene(1);
    }
}
