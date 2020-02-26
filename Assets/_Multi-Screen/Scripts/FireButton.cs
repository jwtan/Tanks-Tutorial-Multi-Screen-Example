using UnityEngine;

namespace Complete
{
    public class FireButton : MonoBehaviour
    {
        public string ButtonName = "Fire1";

        private bool _pressed = false;

        public void OnPointerDown()
        {
            _pressed = true;
            Input.PressButtonDownMobile(ButtonName);
        }

        public void OnPointerUp()
        {
            _pressed = false;
            Input.PressButtonUpMobile(ButtonName);
        }

        private void Update()
        {
            if (_pressed)
                Input.PressButtonMobile(ButtonName);
        }
    }
}
