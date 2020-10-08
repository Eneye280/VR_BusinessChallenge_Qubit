using System;
using UnityEngine;

namespace UnityEngine.XR.Interaction.Toolkit
{
    public class TeleportationAnchor : BaseTeleportationInteractable
    {
        [SerializeField]
        [Tooltip("The transform that represents the teleportation destination")]
        Transform m_TeleportAnchorTransform;
        [SerializeField] internal float widthGizmo;
        [SerializeField] internal float sizeGizmoTransform;

        public Transform teleportAnchorTransform { get { return m_TeleportAnchorTransform; } set { m_TeleportAnchorTransform = value; } }

        private void OnValidate()
        {
            if (teleportAnchorTransform == null)
                teleportAnchorTransform = transform;
        }

        protected override bool GenerateTeleportRequest(XRBaseInteractor interactor, RaycastHit raycastHit, ref TeleportRequest teleportRequest)
        {
            if(teleportAnchorTransform == null)
            {
                return false;
            }

            teleportRequest.destinationPosition = m_TeleportAnchorTransform.position;
            teleportRequest.destinationUpVector = m_TeleportAnchorTransform.up;
            teleportRequest.destinationRotation = m_TeleportAnchorTransform.rotation;            
            teleportRequest.destinationForwardVector = m_TeleportAnchorTransform.forward;
            return true;
        }

        private void OnDrawGizmos()
        {     
            Gizmos.color = Color.blue;
            GizmoHelpers.DrawWireCubeOriented(m_TeleportAnchorTransform.position, m_TeleportAnchorTransform.rotation, widthGizmo);

            GizmoHelpers.DrawAxisArrows(m_TeleportAnchorTransform, sizeGizmoTransform);
        }
    }
}
