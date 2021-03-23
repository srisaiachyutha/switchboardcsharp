using System;
using switchBordNew.enums;

namespace switchBordNew.models
{
    public class Device
    {
        private DeviceType _deviceType;
        private int _currentNumber;
        private SwitchState _state = SwitchState.OFF;

        public int CurrentNumber
        {
            get { return this._currentNumber; }
            set { this._currentNumber = value; }
        }
        public string GiveState()
        {
            return this._state == SwitchState.OFF ? nameof(SwitchState.OFF) : nameof(SwitchState.ON);
        }

        public void ToggleState()
        {
            this._state = this._state == SwitchState.OFF ? SwitchState.ON : SwitchState.OFF;
        }
        public Device(DeviceType deviceType, int currentNumber)
        {
            this._deviceType = deviceType;
            this._currentNumber = currentNumber;
        }
        public void GetStatus()
        {
            Console.WriteLine(this.GetDeviceType() + " " + this.CurrentNumber.ToString() + " is " + this.GiveState());
        }
        public string GetDeviceType()
        {
            switch (this._deviceType)
            {
                case DeviceType.AC:
                    return nameof(DeviceType.AC);
                case DeviceType.BULB:
                    return nameof(DeviceType.BULB);
                case DeviceType.FAN:
                    return nameof(DeviceType.FAN);
                default:
                    return "";
            }
        }
    }

}