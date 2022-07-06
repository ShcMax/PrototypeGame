using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public delegate int TestDelegate(int val1, int val2);
    public delegate T Operation<T, K>(K val);

    event TestDelegate MyEvent;

    public Operation<float, int> TempGeneric;

    public TestDelegate summ;
    public TestDelegate substraction;
    public TestDelegate multiply;
    public TestDelegate divide;

    static int SomeMethod1(int a, int b)
    {
        Debug.Log("Summ " + (a + b));
        return a + b;
    }

    static int SomeMethod2(int a, int b)
    {
        Debug.Log("Sub " + (a - b));
        return a - b;
    }

    static int SomeMethod3(int a, int b)
    {
        Debug.Log("Mult " + (a * b));
        return a * b;
    }

    static int SomeMethod4(int a, int b)
    {
        Debug.Log("Div " + (a / b));
        return a / b;
    }

    private void Start()
    {
        summ = SomeMethod1;
        substraction = SomeMethod2;
        multiply = SomeMethod3;
        divide = SomeMethod4;

        divide += SomeMethod1;
        divide += SomeMethod2;
        divide += SomeMethod3;
        divide += SomeMethod4;

        MyEvent += TempVoid;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            OperationDel(20, 30, substraction);
            MyEvent?.Invoke(40, 60);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            divide?.Invoke(100, 50);
        }
    }

    public void OperationDel(int a, int b, TestDelegate myDelegate)
    {
        myDelegate(a, b);
    }

    public TestDelegate temp()
    {
        return multiply;
    }

    int TempVoid(int x, int y)
    {
        return 0;
    }
}

        
