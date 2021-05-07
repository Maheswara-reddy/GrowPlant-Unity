using UnityEngine;
using UnityEngine.SceneManagement;
public class GamingManager : MonoBehaviour
{
    bool gameHasEnded = false;
    private float timeDelay = 2f;
  public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            //Invoke("Restart",timeDelay);
            Restart();
        }
        
        void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
