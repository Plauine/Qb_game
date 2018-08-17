using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    
    public void TriggerEndGame(){
        Debug.Log("GameManager > TriggerEndGame");
        FindObjectOfType<AnimationController>().EndGame();
        Restart();
    }

    private void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
