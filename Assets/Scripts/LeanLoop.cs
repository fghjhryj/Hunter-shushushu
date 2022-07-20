using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using UnityEngine;

/// <summary>
/// 學習迴圈  協同程序  Coroutine : 等待
/// while、for 教學
/// while do、foreach
/// </summary>

public class LeanLoop : MonoBehaviour
{
    private void Start()
    {
        // 迴圈 : 重複執行

        // while 迴圈語法 :
        // if (布林值) { 程式 } 執行一次
        // while (布林值) { 程式 } 重複執行到布林值為 false


        int count = 0;

        while (count < 5)
        {
            print("while 迴圈 ! " + count);
            count++;
        }

        // for(初始值 ; 條件 ; 迴圈執行後處理)  { 程式 }
        for (int i = 0; i < 5; i++)

            // 協同程序
            // 1. 引用命名空間 System.Collections
            // 2. 定論傳回類型為 IEnumerator 的方法
            // 3. yield return 等待
            // 4. Start Coroutine 啟動
            StartCoroutine(Test());

    }

    private IEnumerator Test()
    {

        print("<color=yellow>第一行</color>");
        yield return new WaitForSeconds(1);
        print("<color=yellow>第二行</color>");
    }


}
