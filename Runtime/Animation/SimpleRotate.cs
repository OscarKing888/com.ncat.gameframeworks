using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

namespace NCat.Animation
{
    public class SimpleRotate : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
    {
        public enum RotationAxis
        {
            Xaxis, Yaxis, Zaxis
        };
        public RotationAxis selectedAxis;
        public float speed = 1f;
        public float speedRate = 1f;
        public float DragRotateSpeed = 0.4f;
        public float RotationY;
        public bool IsWheel;

        private Vector3 axis;

        bool isDraging = false;

        private void UpdateAxis()
        {
            switch (selectedAxis)
            {
                case RotationAxis.Xaxis: axis = Vector3.right; break;
                case RotationAxis.Yaxis: axis = Vector3.up; break;
                case RotationAxis.Zaxis: axis = Vector3.forward; break;
                default: axis = Vector3.right; break;
            }
        }

        // Use this for initialization
        void Start()
        {
            UpdateAxis();
        }

        // Update is called once per frame
        void Update()
        {
            if (!isDraging)
            {
                UpdateAxis();

                if (IsWheel)
                {
                    Vector3 e = transform.rotation.eulerAngles;
                    e.y = RotationY;
                    e.z = 0f;
                    e.x += Time.deltaTime * speed * speedRate;
                    transform.rotation = Quaternion.Euler(e);
                }
                else
                {
                    transform.Rotate(axis * Time.deltaTime * speed * speedRate);
                }

            }
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            isDraging = true;
        }

        public void OnDrag(PointerEventData eventData)
        {
            transform.Rotate(axis * -eventData.delta.x * DragRotateSpeed);
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            isDraging = false;
        }
    }

} // namespace NCat.Animation