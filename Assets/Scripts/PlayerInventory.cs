using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour {
    private int medkits;
    private int energyDrinks;
    private int grenades;
    private int ammo;

    public void AddItem(Item.ItemType itemType) {
        switch (itemType)
        {
            case Item.ItemType.Medkit:
                medkits++;
                Debug.Log("��������� �������. ����� �������: " + medkits);
                break;
            case Item.ItemType.EnergyDrink:
                energyDrinks++;
                Debug.Log("�������� ���������. ����� �����������: " + energyDrinks);
                break;
            case Item.ItemType.Grenade:
                grenades++;
                Debug.Log("��������� �������. ����� ������: " + grenades);
                break;
            case Item.ItemType.Ammo:
                ammo++;
                Debug.Log("��������� �������. ����� ��������: " + ammo);
                break;
        }
    }
}
