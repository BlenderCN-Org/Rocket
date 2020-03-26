using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TableLevelLoader : MonoBehaviour
{
    public string mLevelToLoad;
    public Scene sceneToLoad;
    // Start is called before the first frame update
   

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(mLevelToLoad);
            Debug.Log("Table Hitted");
        }
            
     
    }
}
