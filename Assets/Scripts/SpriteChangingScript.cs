using UnityEngine;

public class SpriteChangingScript : MonoBehaviour
{
    private readonly string[] threeStars = {"Amogus like a ball",
    "Amogus with cat",
    "Chermogus",
    "Dumogus",
    "Goosemogus",
    "Lemogus",
    "Napstablookmogus",
    "Sparkly Amogus",
    "Walking Shrimogus"};

    private string assetPath = "Images/GachaImages/3stars/";
    public SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Roll();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Roll()
    {
        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        string name = threeStars[Random.Range(0, threeStars.Length)];
        Sprite amogus = Resources.Load<Sprite>(assetPath + name);

        if (amogus != null)
        {
            spriteRenderer.sprite = amogus;
        }
        else
            Debug.LogError($"Sprite not found at Resources/{assetPath}{name}");
    }
}
