using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiation : MonoBehaviour {

    public Camera cam;

    public GameObject ShopScreenItems;

    private void Awake()
    {
        placeShopScreen();
    }

    void placeShopScreen()
    {
        Vector3 oldPos = ShopScreenItems.transform.position;
        Vector3 newPos = cam.ScreenToWorldPoint(new Vector3(Screen.width, ShopScreenItems.transform.position.y, ShopScreenItems.transform.position.z));
        newPos.z = oldPos.z;
        newPos.y = oldPos.y;
        ShopScreenItems.transform.position = newPos;
    }
}
