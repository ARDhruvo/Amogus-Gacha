using UnityEngine;

public class TenContextScript : MonoBehaviour
{
    public bool isContextActive;
    public GameObject RollTen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isContextActive = true;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleContext()
    {
        if (isContextActive)
        {
            RollTen.SetActive(true);
            isContextActive = false;
        }
        else
        {
            RollTen.SetActive(false);
            isContextActive = true;
        }
    }
}
