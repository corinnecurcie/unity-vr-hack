/************************************************************************************

Copyright (c) Facebook Technologies, LLC and its affiliates. All rights reserved.  

See SampleFramework license.txt for license terms.  Unless required by applicable law 
or agreed to in writing, the sample code is provided “AS IS” WITHOUT WARRANTIES OR 
CONDITIONS OF ANY KIND, either express or implied.  See the license for specific 
language governing permissions and limitations under the license.

************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace OculusSampleFramework
{
    public class DistanceGrabberSampleModified : MonoBehaviour
    {

        bool museSpherecast = false;
        bool allowGrabThroughWalls = false;

        public bool UseSpherecast
        {
            get { return museSpherecast; }
            set
            {
                museSpherecast = value;
                for (int i = 0; i < m_grabbers.Length; ++i)
                {
                    m_grabbers[i].UseSpherecast = museSpherecast;
                }
            }
        }

        public bool AllowGrabThroughWalls
        {
            get { return allowGrabThroughWalls; }
            set
            {
                allowGrabThroughWalls = value;
                for (int i = 0; i < m_grabbers.Length; ++i)
                {
                    m_grabbers[i].m_preventGrabThroughWalls = !allowGrabThroughWalls;
                }
            }
        }

        [SerializeField]
        DistanceGrabberModified[] m_grabbers;

        // Use this for initialization
        void Start()
        {
            
        }

        private void Update()
        {
            /*
            int numGrabbers = m_grabbers.Length;
            string message = "Num grabbers: " + numGrabbers.ToString();

            Vector3 point = new Vector3(0, 0, 0);
            if (m_grabbers.Length == 1)
            {
                point = m_grabbers[0].transform.position;
            }
            else if (m_grabbers.Length == 2)
            {
                point = Vector3.Lerp(m_grabbers[0].transform.position, m_grabbers[1].transform.position, 0.5f);
            }
            string message2 = "Grabbers Position: " + point.ToString();

            Vector3 leftPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
            Vector3 rightPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
            Vector3 midpoint = Vector3.Lerp(leftPosition, rightPosition, 0.5f);
            string message3 = "Left controller position: " + leftPosition.ToString();
            string message4 = "Right controller position: " + rightPosition.ToString();
            string message5 = "Midpoint position: " + midpoint.ToString();
            DebugUIBuilder.instance.AddLabel(message);
            DebugUIBuilder.instance.AddLabel(message2);
            DebugUIBuilder.instance.AddLabel(message3);
            DebugUIBuilder.instance.AddLabel(message4);
            DebugUIBuilder.instance.AddLabel(message5);
            DebugUIBuilder.instance.Show();
            */
        }

        public void ToggleSphereCasting(Toggle t)
        {
            UseSpherecast = !UseSpherecast;
        }

        public void ToggleGrabThroughWalls(Toggle t)
        {
            AllowGrabThroughWalls = !AllowGrabThroughWalls;
        }
    }
}
