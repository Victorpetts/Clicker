using UnityEngine;
using UnityEngine.UI;


public class Cupcakes : MonoBehaviour
{
    public Text cupcakeAmountText;
    public int cupcakesPerClick = 5;
    
    private int _cupcakeAmount;
    
    public int CupcakeAmount {
        get => this._cupcakeAmount;
        set {
            this._cupcakeAmount = value;
            this.cupcakeAmountText.text = value.ToString("0 Cupcakes");
        } 
    }
    
    void Start()
    {
        CupcakeAmount = PlayerPrefs.GetInt("Cupcakes", 0);
    }
    
    void OnDestroy() {
        PlayerPrefs.SetInt("Cupcakes", CupcakeAmount);
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
}
