using UnityEngine;

public class LeanMethod : MonoBehaviour
{
    // 方法語法
    // 傳回類型 方法自訂名稱 () { 方法內容 }
    // 無傳回 void
    // 方法名稱 Unity 習慣用大寫開頭
    private void Test()
    {
        // 輸出(輸出訊息);
        print("哈囉 沃德 :D");
    }

    // 自訂方法
    // 需要呼叫才會執行

    // Unity 的入口
    // 開始事件 (藍色名稱)
    // 播放遊戲後會執行一次
    // 初始化設定 : 初始金額、三條命等等
    private void Start()
    {
        // 呼叫方法
        // 方法名稱()；
        Test();
        PrintColorText();
     }
    private void PrintColorText()
    {
        // Rich Text
        print("<color=yellow>黃色訊息</color>");
        print("<color=red>紅色訊息</color>");
        print("<size=10><color=#003399>藍色訊息</color></size>");
    }
}
