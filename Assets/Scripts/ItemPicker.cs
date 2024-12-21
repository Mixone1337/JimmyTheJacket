using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
    public enum ItemType { Medkit, EnergyDrink, Grenade, Ammo }
    public ItemType itemType;

    // ���������� ��� ��������������� � �������
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            CollectItem(other.gameObject);
        }
    }

    // �������� ������� � ��������� � ���������
    private void CollectItem(GameObject player) {
        PlayerInventory inventory = player.GetComponent<PlayerInventory>();
        if (inventory != null)
        {
            inventory.AddItem(itemType);
            Destroy(gameObject); // ���������� ������ ����� �������
        }
    }
}
