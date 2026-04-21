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

    private readonly string[] fourStars = {"Borgamogus",
    "Cheesemogus",
    "Eggmogus with Eggshells",
    "Looking Shrimogus",
    "Pancakemogus",
    "Sleeping Breadmogus",
    "Spagghetmogus",
    "Teamogus",
    "Yellow Pizzamogus",};

    private readonly string[] fiveStars = {"Bananamogus",
    "Breadmogus Group",
    "Dumogus with mini Dumogus",
    "Papyramogus",
    "Red Pizzamogus",
    "Sansamogus",
    "Shrimogus Riding a Shrimp",
    "Sweet Potatomogus",
    "Undymogus",
    "Walking Eggmogus"};

    private readonly string[] sixStars = {"Basket Breadmogus",
    "Breakfastmogus",
    "Duo Pizzamogus",
    "Eating Sansamogus",
    "Pancakemogus Impostor",
    "Sitting Eggmogus",
    "Vegimogus"};

    public int rarityThreeStars = 30;
    public int rarityFourStars = 80;
    public int rarityFiveStars = 99;
    // public int raritySixStars = 1;
    // private string assetPath = "Images/GachaImages/";
    // public SpriteRenderer spriteRenderer;
    public Image targetImage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ChangeImage();
        SetDefaultCondition();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetDefaultCondition()
    {
        rarityFiveStars = 99;
        rarityFourStars = 80;
        rarityThreeStars = 30;
        if (targetImage == null)
        {
            Debug.LogError("Target Image is not assigned!", this);
            return;
        }

        Sprite defaultSprite = Resources.Load<Sprite>("Images/GachaImages/default");
        if (defaultSprite != null)
        {
            targetImage.sprite = defaultSprite;
        }
        else
        {
            Debug.LogError("Default sprite not found at Resources/Images/GachaImages/default");
        }
    }

    public void ChangeImage()
    {
        if (targetImage == null)
        {
            Debug.LogError("Target Image is not assigned!", this);
            return;
        }

        int rarity = RarityDecider(Random.Range(0, 1000));
        string[] selectedArray;
        string assetPath = setPath(rarity);
        switch (rarity)
        {
            case 3:
                selectedArray = threeStars;
                break;
            case 4:
                selectedArray = fourStars;
                break;
            case 5:
                selectedArray = fiveStars;
                break;
            case 6:
                selectedArray = sixStars;
                break;
            default:
                selectedArray = threeStars;
                break;
        }

        string randomName = selectedArray[Random.Range(0, selectedArray.Length)];
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

    int RarityDecider(int val)
    {
        int rarityRoll = val % 100;
        if (rarityRoll < rarityThreeStars)
        {
            // Debug.Log(rarityRoll + " < " + rarityThreeStars + " 3 Stars");
            return 3;
        }
        else if (rarityRoll < rarityFourStars)
        {
            // Debug.Log(rarityRoll + " < " + rarityFourStars + " 4 Stars");
            return 4;
        }
        else if (rarityRoll < rarityFiveStars)
        {
            // Debug.Log(rarityRoll + " < " + rarityFiveStars + " 5 Stars");
            return 5;
        }
        else
        {
            // Debug.Log(rarityRoll + " 6 Stars");
            return 6;
        }
    }

    string setPath(int rarity)
    {
        string assetPath = "Images/GachaImages/";
        return assetPath + rarity + "Stars/";
    }
}
