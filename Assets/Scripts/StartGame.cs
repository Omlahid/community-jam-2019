using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.S) &&
            Input.GetKey(KeyCode.T) &&
            Input.GetKey(KeyCode.A) &&
            Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("Main", LoadSceneMode.Single);
        }
    }

    public void CrashGame()
    {
        global::CrashGame.Crash("Cannot find file 'player.png' in '_Assets\sprites' folder");
    }
}