using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorToNextLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {   

        
        //For some reason doesn't work.
        /*
        if (ScoreScript.scoreValue >= 3)
        {
           
            Scene nextScene = SceneManager.GetSceneByName("Second Level");
            SceneManager.LoadSceneAsync(nextScene.name);
            SceneManager.MoveGameObjectToScene(GameObject.Find("Player"), nextScene);
            SceneManager.MoveGameObjectToScene(GameObject.Find("Main Camera"), nextScene);
            SceneManager.SetActiveScene(nextScene);
        }*/
        
        //TODO:
        //USE PREFABS TO CREATE NEW INSTANCE OF PLAYER AT SAME "START" LOCATION FOR EACH SCENE.
        if (ScoreScript.scoreValue >= 3)
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        
        
    }

}
