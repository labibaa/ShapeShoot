using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    
    public GameObject panel;
    public ProductDisplay productDisplay;
    public GameObject cartPanel;

    public void OnClickButton(Cart selectedFurniture)
    {
        productDisplay.GetProductDetails(selectedFurniture);
        panel.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("clicked");
            panel.SetActive(false);
        }
        //else if (Input.GetKeyDown(KeyCode.Return))
        //{
        //    cartPanel.SetActive(true);
        //}
    }
    public void Back()
    {
        panel.SetActive(false);
    }

    public void AddToCart()
    {
        cartPanel.SetActive(true);
    }
}
