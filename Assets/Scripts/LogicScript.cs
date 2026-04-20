using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    private readonly string[] threeStars = {"Amogus Like a Ball",
    "Amogus With a Cat",
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

    public int rarityThreeStars = 3;
    public int rarityFourStars = 7;
    public int rarityFiveStars = 9;
    // public int raritySixStars = 1;

    private string assetPath = "Assets/Images/GachaImages/";


    [ContextMenu("Roll the Dice")]
    void rollTen()
    {
        for (int i = 0; i < 10; i++)
        {
            int randomVal = Random.Range(0, 100);
            int rarity = rarityDecider(randomVal);
            string name;
            if (rarity == 3)
            {
                name = threeStars[randomVal % threeStars.Length];

                Sprite image = Resources.Load<Sprite>(assetPath + rarity + "Stars/" + (name.Replace(" ", "")) + ".jpg");
            }
            else if (rarity == 4)
            {
                name = fourStars[randomVal % fourStars.Length];
                Sprite image = Resources.Load<Sprite>(assetPath + rarity + "Stars/" + (name.Replace(" ", "")) + ".jpg");
            }
            else if (rarity == 5)
            {
                name = fiveStars[randomVal % fiveStars.Length];
                Sprite image = Resources.Load<Sprite>(assetPath + rarity + "Stars/" + (name.Replace(" ", "")) + ".jpg");

            }
            else
            {
                name = sixStars[randomVal % sixStars.Length];
                Sprite image = Resources.Load<Sprite>(assetPath + rarity + "Stars/" + (name.Replace(" ", "")) + ".jpg");

            }
            Debug.Log($"Roll {i + 1}: {name} (Rarity: {rarity} stars)");
        }
    }

    void rollOne()
    {
        int randomVal = Random.Range(0, 100);
        int rarity = rarityDecider(randomVal);
        string name;
        if (rarity == 3)
        {
            name = threeStars[randomVal % threeStars.Length];
            Sprite image = Resources.Load<Sprite>(assetPath + rarity + "Stars/" + (name.Replace(" ", "")) + ".jpg");
        }
        else if (rarity == 4)
        {
            name = fourStars[randomVal % fourStars.Length];
            Sprite image = Resources.Load<Sprite>(assetPath + rarity + "Stars/" + (name.Replace(" ", "")) + ".jpg");
        }
        else if (rarity == 5)
        {
            name = fiveStars[randomVal % fiveStars.Length];
            Sprite image = Resources.Load<Sprite>(assetPath + rarity + "Stars/" + (name.Replace(" ", "")) + ".jpg");

        }
        else
        {
            name = sixStars[randomVal % sixStars.Length];
            Sprite image = Resources.Load<Sprite>(assetPath + rarity + "Stars/" + (name.Replace(" ", "")) + ".jpg");

        }
        Debug.Log($"Roll: {name} (Rarity: {rarity} stars)");
    }

    int rarityDecider(int val)
    {
        int rarityRoll = val % 10;
        if (rarityRoll < rarityThreeStars)
        {
            return 3;
        }
        else if (rarityRoll < rarityFourStars)
        {
            return 4;
        }
        else if (rarityRoll < rarityFiveStars)
        {
            return 5;
        }
        else
        {
            return 6;
        }
    }

}
