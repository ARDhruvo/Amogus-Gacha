using UnityEngine;
using UnityEngine.UI;

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
    // public SpriteRenderer spriteRenderer;
    public Image targetImage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChangeImage();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeImage()
    {
        if (targetImage == null)
        {
            Debug.LogError("Target Image is not assigned!", this);
            return;
        }

        string randomName = threeStars[Random.Range(0, threeStars.Length)];
        Sprite newSprite = Resources.Load<Sprite>(assetPath + randomName);

        if (newSprite != null)
        {
            targetImage.sprite = newSprite;
        }
        else
        {
            Debug.LogError($"Sprite not found at Resources/{assetPath}{randomName}");
        }
    }
}
