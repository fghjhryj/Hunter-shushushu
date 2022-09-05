using UnityEngine;
using TMPro;

namespace KID
{
    /// <summary>
    /// �޲z�����G��s�����ƶq
    /// </summary>
    public class ManagerCoin : MonoBehaviour
    {
        /// <summary>
        /// �����ƶq
        /// </summary>
        private TextMeshProUGUI textCoin;
        /// <summary>
        /// �����`��
        /// </summary>
        private int totalCoin;

        private void Awake()
        {
            textCoin = GameObject.Find("�����ƶq").GetComponent<TextMeshProUGUI>();
        }

        /// <summary>
        /// �K�[�@�Ӫ����ç�s����
        /// </summary>
        public void AddCoinAndUpdateUI()
        {
            totalCoin++;
            textCoin.text = totalCoin.ToString();
        }
    }
}
