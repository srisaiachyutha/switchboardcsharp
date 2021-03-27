using switchBordNew.enums;

namespace switchBordNew.models
{
    class Fan : Device
    {
        public Fan(int currentNumber) :
        base(DeviceType.FAN, currentNumber)
        {

        }
    }
}