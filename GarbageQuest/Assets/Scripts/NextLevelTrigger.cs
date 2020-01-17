using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelTrigger : MonoBehaviour
{

    public Animator animator;
    private void OnTriggerEnter(Collider other) {
        StartCoroutine(nextLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator nextLevel(int index) {
        animator.SetTrigger("Change");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(index);
    }
}
