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
    public Text Debugtxt;
    float value;
    float SGDamount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void conversion()
    {
        SGDamount = float.Parse(txtAmount.text);
        

        if (USD.GetComponent<Toggle>().isOn == true)
        {
            Debugtxt.text = "";
            value = SGDamount * 0.74F;
            txtConverted.text = value.ToString() + " USD";
        }
        if (Yen.GetComponent<Toggle>().isOn == true)
        {
            Debugtxt.text = "";
            value = SGDamount * 82.78f;
            txtConverted.text = value.ToString() + " JPN";
        }
        if (USD.GetComponent<Toggle>().isOn == true&& Yen.GetComponent<Toggle>().isOn == true)
        {
            Debugtxt.text = "Please Select Only One";
            txtConverted.text = "";
        }
        else if (USD.GetComponent<Toggle>().isOn == false && Yen.GetComponent<Toggle>().isOn == false)
        {
            Debugtxt.text = "Please Select One";
        }
    }
    public void clear()
    {
        txtAmount.text = "";
        txtConverted.text = "";
    }
}
