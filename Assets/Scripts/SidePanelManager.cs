using UnityEngine;

public static class SidePanelManager{

    static float ShopUIShiftAmount = 200;

    public static void ShiftLeft(GameObject canvas)
    {
        canvas.transform.position = new Vector2(-ShopUIShiftAmount, canvas.transform.position.y);
    }

    public static void ResetUIPosition(GameObject canvas)
    {
        canvas.transform.position = Vector2.zero;
    }
}
