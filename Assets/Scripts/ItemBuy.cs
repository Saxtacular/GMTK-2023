using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemBuy : MonoBehaviour
{
    [SerializeField] private Transform itemSlot;
    [SerializeField] private TextMeshProUGUI buyText;
    [SerializeField] private MoneyManager moneyManager;
    [SerializeField] private GameObject draggableItemPrefab;

    private void OnEnable()
    {
        ShopItem shopItem = NPCManager.Instance.GetCurrentVisitor().inventory[0];
        GameObject draggableItemInstance = Instantiate(draggableItemPrefab, itemSlot);

        draggableItemInstance.GetComponent<DraggableItem>().shopItem = shopItem;
    }
}