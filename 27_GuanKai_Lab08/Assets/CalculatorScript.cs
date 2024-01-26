using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CalculatorScript : MonoBehaviour
{
    public InputField txtConverted;
    public Toggle USD;
    public Toggle Yen;
    public Toggle Rng;
    public Toggle Won;
    public Toggle Euro;
    public Toggle TWD;
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
        if (USD.GetComponent<Toggle>().isOn == true&& Yen.GetComponent<Toggle>().isOn == true && Won.GetComponent<Toggle>().isOn == true && Rng.GetComponent<Toggle>().isOn == true && Euro.GetComponent<Toggle>().isOn == true && TWD.GetComponent<Toggle>().isOn == true)
        {
            Debugtxt.text = "Please Select Only One";
            txtConverted.text = "";
        }
        else if (USD.GetComponent<Toggle>().isOn == false && Yen.GetComponent<Toggle>().isOn == false&&Rng.GetComponent<Toggle>().isOn == false && Won.GetComponent<Toggle>().isOn == false && Euro.GetComponent<Toggle>().isOn == false && TWD.GetComponent<Toggle>().isOn == false)
        {
            Debugtxt.text = "Please Select One";
        }
        if (Rng.GetComponent<Toggle>().isOn == true)
        {
            Debugtxt.text = "";
            value = SGDamount * 3.08f;
            txtConverted.text = value.ToString() + " RM";
        }
        if (Euro.GetComponent<Toggle>().isOn == true)
        {
            Debugtxt.text = "";
            value = SGDamount * 0.63f;
            txtConverted.text = value.ToString() + " EUR";
        }
        if (Won.GetComponent<Toggle>().isOn == true)
        {
            Debugtxt.text = "";
            value = SGDamount * 881.54f;
            txtConverted.text = value.ToString() + " KRW";
        }
        if (TWD.GetComponent<Toggle>().isOn == true)
        {
            Debugtxt.text = "";
            value = SGDamount * 20.73f;
            txtConverted.text = value.ToString() + " TWD";
        }
    }
    public void clear()
    {
        txtAmount.text = "";
        txtConverted.text = "";
    }
}
