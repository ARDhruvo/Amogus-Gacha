using UnityEngine;
using UnityEngine.SceneManagement;

public class OneContextScript : MonoBehaviour
{
    public bool isContextActive;
    public GameObject RollOne;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isContextActive = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleContext()
    {
        if (isContextActive)
        {
            RollOne.SetActive(true);
            isContextActive = false;
        }
        else
        {
            RollOne.SetActive(false);
            isContextActive = true;
        }
    }
}
