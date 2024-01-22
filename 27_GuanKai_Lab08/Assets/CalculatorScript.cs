using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CalculatorScript : MonoBehaviour
{
    public InputField txtConverted;
    public Toggle USD;
    public Toggle Yen;
    public InputField txtAmount;
    float value;
    float SGDamount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        conversion();
    }
    public void conversion()
    {
        SGDamount = float.Parse(txtAmount.text);

        if (USD.GetComponent<Toggle>().isOn == true)
        {
            value = SGDamount * 0.74F;
            txtConverted.text = value.ToString() + " USD";
        }
        if (Yen.GetComponent<Toggle>().isOn == true)
        {
            value = SGDamount * 82.78f;
            txtConverted.text = value.ToString() + " JPN";
        }
    }
}
