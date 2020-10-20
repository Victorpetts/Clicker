using UnityEngine;
using UnityEngine.UI;


public class Gold : MonoBehaviour
{
    public int goldAmount;
    public Text goldAmountText;
    void Start()
    {
        
    }
    
    void Update()
    {
        goldAmountText.text = goldAmount.ToString("You have 0 Cupcakes");
        if (Input.GetMouseButtonDown(0)) {
            ProduceGold();
        }
    }

    public void ProduceGold()
    {
        goldAmount += 5;
    }
}
