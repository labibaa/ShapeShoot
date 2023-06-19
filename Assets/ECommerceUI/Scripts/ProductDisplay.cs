using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProductDisplay : MonoBehaviour
{
    public TextMeshProUGUI productNameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI priceText;

    public Image productImageShow;

    

    public void GetProductDetails(Cart product)
    {
        Debug.Log("product0" + product.price);
        productNameText.text = product.productName;
        descriptionText.text = product.description;
        priceText.text = product.price;

        productImageShow.sprite = product.productImage;
    }

}
