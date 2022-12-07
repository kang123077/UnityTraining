using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int health = 30;
    int level = 5;
    void Start()
    {
        // 1. ����
        int level = 5;
        float strength = 15.5f;
        string playerName = "SwordMan";
        bool isFullLevel = false;

        // 2. �׷��� ����
        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        List<string> items = new List<string>();
        items.Add("LifePotion30");
        items.Add("manaPotion30");

        // items.RemoveAt(0);
        // Debug.Log(items[0]);
        // Debug.Log(items[1]);

        // 3. ������
        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        // ���� �������� ���� ����ġ
        int nextExp = 300 - (exp % 300);
        // Debug.Log("nextExp = " + nextExp);

        string title = "Legendary";
        // Debug.Log("Whe are you?");
        // Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        // Debug.Log("FullLevel?? " + isFullLevel);

        bool isEndTutorial = level > 10;
        // Debug.Log("TutorialEnd?? " + isEndTutorial);

        int mana = 15;
        // bool isBadCondition = health <= 50 && mana <= 20;
        bool isBadCondition = health <= 50 || mana <= 20;

        string condition = isBadCondition ? "Bad" : "Good";
        // Debug.Log("ConditionBad?? " + isBadCondition);

        // 4. Ű����
        // int float string bool new List

        // 5. ���ǹ�
        if (condition == "Bad")
        {
            // Debug.Log("Condition is bad, need rest");
        }
        else
        {
            // Debug.Log("Condition is Good");
        }

        if (isBadCondition && items[0] == "LifePotion30")
        {
            items.RemoveAt(0);
            health += 30;
            // Debug.Log("Using LifePotion30");
        }
        else if (isBadCondition && items[0] == "ManaPotion30")
        {
            items.RemoveAt(0);
            mana += 30;
            // Debug.Log("Using Manapotion30");
        }

        switch (monsters[1])
        {
            case "������":
            case "�縷��":
                // Debug.Log("Slime");
                break;
            case "�Ǹ�":
                // Debug.Log("Devil");
                break;
            case "��":
                // Debug.Log("Golem");
                break;
            default:
                // Debug.Log("???");
                break;
        }

        // 6. �ݺ���

        /*
        while (health > 0)
        {
            health--;
            if (health > 0)
                Debug.Log("Poison Damage!!");
            else
                Debug.Log("You Die");

            if (health == 10)
            {
                Debug.Log("Using CurePotion");
                break;
            }
        }

        for (int count = 0; count < 10; count++)
        {
            health++;
            Debug.Log("Healing Now... " + health);
        }

        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("Monsters in this Area = " + monsters[index]);
        }

        foreach (string monster in monsters)
        {
            Debug.Log("monsters in the Area = " + monster);
        }

        // health = Heal(health);
        Heal2();

        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("���� " + monsters[index] + "���� " +
                Battle(monsterLevel[index]));
        }
        */

        // 8. Ŭ����
        Player player = new Player(); // �ν��Ͻ�ȭ
        player.id = 0;
        player.name = "Mage";
        player.title = "Wise";
        player.strength = 2.4f;
        player.weapon = "wood stab";
        Debug.Log(player.Talk());
        Debug.Log(player.name + "�� ������" + player.level + "�Դϴ�.");
        Debug.Log(player.Move());
    }

    // 7. �Լ� (�޼ҵ�)
    int Heal(int currentHealth)
    {
        currentHealth += 10;
        Debug.Log("Healing!!" + currentHealth);
        return currentHealth;
    }
    void Heal2()
    {
        health += 10;
        Debug.Log("Healing!!" + health);
    }

    string Battle(int monsterlevel)
    {
        string result;
        if (level >= monsterlevel)
            result = "Win!";
        else
            result = "Defeat!";

        return result;
    }
}