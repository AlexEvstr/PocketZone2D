using UnityEngine;
using UnityEngine.SceneManagement;

public class UITryAgainButton : MonoBehaviour
{
    public void TryAgain()
    {
        SceneManager.LoadScene("GameplayScene");
    }
}