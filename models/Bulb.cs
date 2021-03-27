using switchBordNew.enums;

namespace switchBordNew.models
{
    class Bulb : Device
    {
        public Bulb(int currentNumber) :
        base(DeviceType.BULB, currentNumber)
        {

        }
    }
}