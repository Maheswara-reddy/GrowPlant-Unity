using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myScore : MonoBehaviour
{
    public Text myGameScore;
    public Text remainingPlants;
    public Text remainingPanels;
    private plantCollector anotherScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        anotherScript = GetComponent<plantCollector>();
        myGameScore.text = "Score : " + anotherScript.scoreOfGame;
        remainingPlants.text = "Plants :" + anotherScript.plantCount;
        remainingPanels.text = "Panels :" + anotherScript.panelCount;
    }
}
