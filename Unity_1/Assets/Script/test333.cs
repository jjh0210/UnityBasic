using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test333 : MonoBehaviour
{
    // Start is called before the first frame update
    int count;

    private void Awake()
    {
        count = 0;
    }

    void Start()
    {

    }
    
    public void Gacha()
    {
        int number = 0;

        while(number < 10)
        {
            int randomValue = Random.Range(1, 101);

            Debug.Log($"랜덤한 값은 : {randomValue} 입니다");
            // count 81
            if (8 <= count)
            {
                Debug.Log("확정으로 '각청'을 뽑았다!");
                count = 0;
            }
            else if (randomValue <= 10) // 1 ~ 10 -> 10%
            {
                Debug.Log("'각청'을 뽑았다!");
            }
            else if (randomValue <= 30) // 11 ~ 30
            {
                Debug.Log("'모나'을 뽑았다!");
            }
            else
            {
                Debug.Log("'치치'를 뽑아버렸다!");
            }


            number++;
        }



        // 확률이 10%면 로그에 '각청'을 뽑았다!
        // 확률이 20%면 로그에 '모나'를 뽑았다!
        // 나머지 70% 확률로 '치치'를 뽑아버렸다!
        //for (int i = 0; i < 10; i++)
        //{
           // int randomValue = Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다. (1 ~ 100) 

           // Debug.Log($"랜덤한 값은 : {randomValue} 입니다");
            // count 81
           //if (8 <= count)
            //{
               // Debug.Log("확정으로 '각청'을 뽑았다!");
               // count = 0;
            //}
            //else if (randomValue <= 10) // 1 ~ 10 -> 10%
            //{
                //Debug.Log("'각청'을 뽑았다!");
           // }
           // else if (randomValue <= 30) // 11 ~ 30
            //{
                //Debug.Log("'모나'을 뽑았다!");
            //}
           // else
           // {
               // Debug.Log("'치치'를 뽑아버렸다!");
           // }

            //count++;
       // }
    }

    public void GachaSwitch()
    {
        // 
        int randomValue = Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다. (1 ~ 100) 

        int selectNumbe = 0;

        switch (selectNumbe) //0
        {
            case 0:
                // 은색 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        // 픽업 캐릭 : 이번 뽑기에 확률이 높게  설정되는 캐릭터
                        // 유저들이 특정 캐릭터를 목표하고 뽑게 만드는 시스템
                        Debug.Log("'은색 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;

            case 1:
                // 파란 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'파란 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;
            case 2:
                // 분홍 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'분홍 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;

            default:
                // 파란 머리 꼬마 캐릭터가 나온다.
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'파란 머리 꼬마'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;
        }
    }
    public void testing()
    {
        for (int i = 0; i < 10; i++) ;
        int randomValue = Random.Range(1, 101);




    }
}