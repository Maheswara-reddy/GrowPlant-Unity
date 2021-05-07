using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
using UnityEditor;

public class Timelimiter : MonoBehaviour
{
    public float timeLeft = 10.0f;
    public Text startText; // used for showing countdown from 3, 2, 1 


    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        if (timeLeft == 0)
        {
            //Do something useful or Load a new game scene depending on your use-case
            EditorApplication.Exit(0);
        }
    }
}
