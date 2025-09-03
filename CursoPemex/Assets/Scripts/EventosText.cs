using UnityEngine;
using UnityEngine.SceneManagement;

public class EventosText : MonoBehaviour
{

    public void SceneChanger(int num)
    {
        SceneManager.LoadScene(num);
    }
}
