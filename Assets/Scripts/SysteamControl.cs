using UnityEngine;

// �R�W�Ŷ� namespace �Ŷ��W�� { �ӪŶ������e }
namespace KID
{
    /// <summary>
    /// ���a����t��
    /// �������B�o�g�u�]
    /// </summary>
    public class SysteamControl : MonoBehaviour
    {
        #region ���
        // GameObject �C������
        // �s�񶥼h���O���Ϊ̱M�פ�������
        [Header("�b�Y")]
        public GameObject arrow;
        [Header("����t��"), Range(0, 500)]
        public float speedTurn = 10.5f;
        [Header("�u�]���s��")]
        public GameObject marble;
        [Header("�u�]�i�H�o�g���`��"), Range(0, 100)]
        public int canShootMarbleTotal = 15;
        #endregion

        #region �ƥ�
        #endregion

        #region ��k
        /// <summary>
        /// ���ਤ��A�����⭱�۷ƹ���m
        /// </summary>
        private void TurnCharacter()
        {

        }

        /// <summary>
        /// �o�g�u�]�A�ھ��`�Ƶo�g�u�]����
        /// </summary>
        private void ShootMarble()
        {

        }

        /// <summary>
        /// �^���u�]
        /// </summary>
        private void RecycleMarble()
        {

        }
        #endregion
    }
}

