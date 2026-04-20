using UnityEngine;

public class ImageChangingScript : MonoBehaviour
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

    public int heightPx = 960;
    public int widthPx = 960;
    private string assetPath = "Images/GachaImages/3stars/";
    public SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
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

    // Update is called once per frame
    void Update()
    {

    }
}
