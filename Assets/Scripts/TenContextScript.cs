using UnityEngine;
using UnityEngine.SceneManagement;

public class TenContextScript : MonoBehaviour
{
    public bool isContextActive;
    public GameObject RollTen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isContextActive = false;
        ToggleContext();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleContext()
    {
        isContextActive = !isContextActive;
        if (isContextActive)
        {
            RollTen.SetActive(true);
        }
        else
        {
            RollTen.SetActive(false);
        }
    }
}
