using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class purchasefailed : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnPurchaseFailed()
    {
        Debug.Log($"Purchase failed - Product: ");
    }
}
