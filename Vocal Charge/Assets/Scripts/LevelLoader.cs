using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

    public Animator transition;
    public float transitionTime = 1.0f;


    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButton(0)) {

        //    LoadNextLevel();
        //}

    }

    public void LoadNextLevel() {

        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    //Corountine
    IEnumerator LoadLevel(int levelIndex) {

        //Activate animation
        transition.SetTrigger("Start");

        //Waiting time
        yield return new WaitForSeconds(transitionTime);

        //Loading scene
        SceneManager.LoadScene(levelIndex);
    }
}
