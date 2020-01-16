using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryTellingManager : MonoBehaviour
{
    public GameObject[] arrayTextBox;

    public float timeBetweenTextBox;
    private int current;

    public float waitTimeStart = 2.0f;

    private bool done;

    // Start is called before the first frame update
    void Start(){
        current = 0;
        StartCoroutine(waitStart());
    }

    IEnumerator waitStart() {
        yield return new WaitForSeconds(waitTimeStart);
        if(current < arrayTextBox.Length) {
            StartCoroutine(displayTextBox(arrayTextBox[current], timeBetweenTextBox));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(done) {
            if(current < arrayTextBox.Length) {
                StartCoroutine(displayTextBox(arrayTextBox[current], timeBetweenTextBox));
            }
        }
    }

    IEnumerator displayTextBox(GameObject obj, float offset) {
        done = false;

        obj.SetActive(true);
        float time = obj.GetComponent<TextBox>().timeNeeded();

        yield return new WaitForSeconds(time+offset);

        obj.SetActive(false);

        done = true;
        current++;
    }
}
