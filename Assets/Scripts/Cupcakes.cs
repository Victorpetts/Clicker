using UnityEngine;
using UnityEngine.UI;


public class Cupcakes : MonoBehaviour
{
    public Text cupcakeAmountText;
    public Text pressAmountText;
    
    public int cupcakesPerClick = 5;
    
    private int _pressAmount;
    private int _cupcakeAmount;
    
    public int CupcakeAmount {
        get => this._cupcakeAmount;
        set {
            _cupcakeAmount = value;
            cupcakeAmountText.text = value.ToString("0 Cupcakes");
        } 
    }
    
    public int PressAmount {
        get => this._pressAmount;
        set {
            _pressAmount = value;
            pressAmountText.text = value.ToString("Cupcake presses: 0");
        } 
    }
    
    void Start()
    {
        CupcakeAmount = PlayerPrefs.GetInt("Cupcakes", 0);
        PressAmount = PlayerPrefs.GetInt("Presses", 0);
    }
    
    void OnDestroy() {
        PlayerPrefs.SetInt("Cupcakes", CupcakeAmount);
        PlayerPrefs.SetInt("Presses", PressAmount);
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            ProduceCupcakes();
        }
    }

    public void ProduceCupcakes()
    {
        CupcakeAmount += cupcakesPerClick;
    }
    
    public void CreatePress()
    {
        if (CupcakeAmount >= 100) {
            CupcakeAmount -= 100;
            PressAmount++;
        }
    }
}
