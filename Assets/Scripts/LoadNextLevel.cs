using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    // Set this to the tag your car uses (default: "Player")
    public string carTag = "Player";

    // Set this to the name of your next level
    public string nextLevelName = "Level02";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(carTag))
        {
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
