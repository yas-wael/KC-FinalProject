using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class play : MonoBehaviour
{
   public void OpenNext(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
} 

