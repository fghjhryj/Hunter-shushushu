using UnityEngine;
using UnityEngine.Events;

namespace KID
{
    /// <summary>
    /// �^�X�t�ΡG���a�μĤH�^�X�޲z
    /// </summary>
    public class SystemTurn : MonoBehaviour
    {
        #region ���
        /// <summary>
        /// �ĤH�^�X
        /// </summary>
        public UnityEvent onTurnEnemy;

        private SystemControl systemControl;
        private SystemSpawn systemSpawn;
        private RecycleArea recycleArea;

        /// <summary>
        /// �u�]�`��
        /// </summary>
        private int totalCountMarble;
        /// <summary>
        /// �Ǫ��P�i�H�Y���u�]�s���`��
        /// </summary>
        private int totalCountEnemyLive;
        /// <summary>
        /// �^���u�]�ƶq
        /// </summary>
        private int totalRecycleMarble;
        private bool canSpawn = true;
        #endregion



        private void Awake()
        {
            systemControl = GameObject.Find("�����L").GetComponent<SystemControl>();
            systemSpawn = GameObject.Find("�ͦ��Ǫ��t��").GetComponent<SystemSpawn>();
            recycleArea = GameObject.Find("�^���ϰ�").GetComponent<RecycleArea>();

            recycleArea.onRecycle.AddListener(RecycleMarble);
        }

        /// <summary>
        /// �^���u�]
        /// </summary>
        private void RecycleMarble()
        {
            totalCountMarble = systemControl.canShootMarbleTotal;

            totalRecycleMarble++;
            // print("<color=yellow>�u�]�^���ƶq�G" + totalRecycleMarble + "</color>");

            if (totalRecycleMarble == totalCountMarble)
            {
                // print("�^�������A���ĤH�^�X");
                onTurnEnemy.Invoke();
            }
        }

        /// <summary>
        /// ���ʵ�����ͦ��ĤH�P�u�]
        /// </summary>
        public void MoveEndSpawnEnemy()
        {
            if (!canSpawn) return;

            canSpawn = false;
            systemSpawn.SpawnRandomEnemy();
            Invoke("PlayerTurn", 1);
        }

        /// <summary>
        /// ���a�^�X
        /// </summary>
        private void PlayerTurn()
        {
            systemControl.canShootMarble = true;
            canSpawn = true;
            totalRecycleMarble = 0;
        }
    }
}