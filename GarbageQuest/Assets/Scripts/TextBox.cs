using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBox : MonoBehaviour
{
    public float animationTime;
    public float textShowTime;

    private bool m_ended;

    public Animator animator;

    // Start is called before the first frame update
    void Start() {
        StartCoroutine(showTextBox(animationTime, textShowTime));
    }

    IEnumerator showTextBox(float anim, float showTime) {
        // on attends que l'animation soit fini
        // et le temps d'affichage de la box
        yield return new WaitForSeconds(anim + showTime);

        animator.SetTrigger("End");
    }

    public float timeNeeded() {
        return 2 * animationTime + textShowTime;
    }

}
