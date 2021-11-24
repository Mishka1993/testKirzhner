using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddChipsManager : MonoBehaviour
{
    [SerializeField]
    private Slider sladerPrice;
    [SerializeField]
    private InputField textFieldPrice;
    [SerializeField]
    public GameObject Panel;

    void OnEnable()
    {
        sladerPrice.onValueChanged.AddListener(ChangeValue);
        textFieldPrice.onValueChanged.AddListener(InputFieldValue);
        ChangeValue(sladerPrice.value);
        InputFieldValue(textFieldPrice.text);
    }

    public void ChangeValue(float value)
    {
        textFieldPrice.text = value.ToString();
    }
    public void InputFieldValue(string text)
    {

        sladerPrice.value = System.Convert.ToSingle(text);
    }

    public void MaxValue()
    {
        sladerPrice.value = sladerPrice.maxValue;
    }
    public void MinValue()
    {
        sladerPrice.value = sladerPrice.minValue;
    }
    public void DestroyPanel() {
        Destroy(Panel);
    }
}
