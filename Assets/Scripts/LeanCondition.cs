using UnityEngine;


/// <summary>
/// 條件式 (判斷式)
/// 1. if
/// 2. switch
/// </summary>


public class LeanCondition : MonoBehaviour
{

    public bool openDoor;

    private void Start()
    {
        #region if 判斷式
        // if 語法 : 
        // if (布林值)  { 布林值等於 true 會執行 }
        if (false)
        {
            print("我在判斷式 if 內");
        }

        #endregion

    }

    private void Update()
    {
        // 如果 openDoor 等於 ture 就開門，否則關門
        // 如果 
        // if 語法 :
        // if (布林值) { 布林值等於 ture 會執行 }
        // 否則 
        // else { 布林值等於 fals 會執行 }
        // else 一定要放在 if 下方，不能單獨使用
        if (openDoor)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }

        // else if () {}
        // 無限數量
        // 連擊數 < 100 攻擊力 + 0%
        // 連擊數 >= 100 攻擊力 +10%
        // 連擊數 >= 200 攻擊力 +20%
        if (combo < 100)
        {
            print("攻擊力 + 0%");
        }
        else if (combo >= 200)
        {
            print("攻擊力 + 20%");
        }
        else if (combo >= 100)
        {
            print("攻擊力 + 10%");
        }

    }


}
