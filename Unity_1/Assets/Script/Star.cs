using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    string star;
    private string i;
    // Start is called before the first frame update
    void Start()
    {
        
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty;
        // ������ 1
        int number = 0;
        while (number < 5)
        {
            int i = 0;

                while(i <= number)
                {
                    star += "��";
                    i++;
                }

                star += "\n"; // �ٹٲ�

                number++; // 

        }
        Debug.Log(star);
    }
        

    public void Phase2()
    {
        star = string.Empty;

        // ������ 2


        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // ������ 3


        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // ������ 4


        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // ������ 5


        Debug.Log(star);
    }
}
