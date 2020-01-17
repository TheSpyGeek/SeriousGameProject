using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public float animationTime = 1.0f;
    public Animator transition;

    public void PlayGame()
	{
        StartCoroutine(loadNextScene(SceneManager.GetActiveScene().buildIndex + 1));
	}



    IEnumerator loadNextScene(int index) {
        transition.SetTrigger("Change");

        yield return new WaitForSeconds(animationTime);

        SceneManager.LoadScene(index);
    }

	public void QuitGame()
	{
		Debug.Log("QUIT");
		Application.Quit();
	}
}
