using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaTest : MonoBehaviour
{

    int randomvalue; // ���� Ȯ�� ����
    string[] characterList = new string[10];


    // Start is called before the first frame update
    void Start() // ĳ���� ����
    {
        randomvalue = Random.Range(1, 101);

        characterList[0] = "�ź���";
        characterList[1] = "������";
        characterList[2] = "�����";
        characterList[3] = "��踻";
        characterList[4] = "ȣ����";
        characterList[5] = "����";
        characterList[6] = "�罿";
        characterList[7] = "�ϸ�";
        characterList[8] = "Ļ�ŷ�";
        characterList[9] = "�䳢";

    }

    public void Tiger()
    {
        for (int i = 0; i < 10; i++)
        {
            int randomValue = Random.Range(1, 101); // �ݺ����� �� ������ ����

            if (randomValue <= 10)
            {
                Debug.Log(characterList[4] + " �� �̾Ҵ�!"); // ȣ����
            }
            else if (randomValue <= 30)
            {
                Debug.Log(characterList[6] + " �� �̾Ҵ�!"); // �罿
            }
            else
            {
                Debug.Log(characterList[9] + " �� �̾Ҵ�!"); // �䳢
            }
        }
    }
}
