using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plantCollector : MonoBehaviour
{
    public int plantCount = 0;
    public int scoreOfGame = 0;
    public int panelCount = 0;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 9 && plantCount < 11)
        {
            Destroy(other.gameObject);
            plantCount++;
        }
        if (other.gameObject.layer == 9 && plantCount > 10)
        {
        }

        if (other.gameObject.layer == 10 && panelCount < 6)
        {
            Destroy(other.gameObject);
            panelCount++;
        }

        if (other.gameObject.layer == 10 && panelCount > 5)
        {
        }

        if (other.gameObject.layer == 11 && plantCount > 0)
        {
            plantCount--;
            scoreOfGame = scoreOfGame + 10;
        }
        if (other.gameObject.layer == 11 && plantCount <= 0)
        { 
        }
        if (other.gameObject.layer == 12 && panelCount > 0)
        {
            panelCount--;
            scoreOfGame = scoreOfGame + 20;
        }
        if (other.gameObject.layer == 12 && panelCount <= 0)
        {
        }


    }
}
