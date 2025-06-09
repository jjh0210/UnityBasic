using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class test444 : MonoBehaviour
{
    public TextMeshProUGUI Txt_Bumin;

    string[] character = { "정은교", "김한나", "손석현", "이윤호", "엄지성", "박현아", "차정훈", "최현석" };
    List<string> characterList = new List<string>();

    public void ArrayGacha() // character.Length
    {
        int randomValue = Random.Range(0, character.Length); // 8 , 0 ~ 7

        Debug.Log("범인은? " + character[randomValue] + "님 였습니다.");
        Txt_Bumin.text = "범인은? " + character[randomValue] + "님 였습니다.";
    }

    public void ListGacha() // characterList.Count
    {
        int randomValue = Random.Range(0, characterList.Count);  // 8 , 0 ~ 7
        Txt_Bumin.text = "범인은? " + characterList[randomValue] + "님 였습니다.";
    }

    public void AddList()
    {
        // character 배열에는 사람 이름이 있습니다.
        // characterList에는 아무 데이터도 없습니다.

        // character 배열의 데이터를 charcterList에다가 넣어주는 식을 만들어봅시다.
        // 우리가 배운 반복문을 사용해서 만들어 봅시다.

        for (int i = 0; i < character.Length; i++) // i < 8 -> 0 ~ 7
        {
            characterList.Add(character[i]);
        }

        for (int i = 0; i < characterList.Count; i++)
        {
            Debug.Log(characterList[i]);
        }
    }
}
