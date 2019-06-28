using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
        public GameObject player; // 玉のオブジェクト

        private Vector3 offset; // 玉からカメラまでの距離
        public static CameraController m_instance;
        void Start()
        {
                //offset = transform.position - player.transform.position;
                m_instance=this;
        }
        void LateUpdate()
        {
                //transform.position = player.transform.position + offset;
        }
        void Update(){
                //m_instance=this;
        }
}
