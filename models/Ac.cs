using switchBordNew.enums;

namespace switchBordNew.models
{
    class Ac : Device
    {
        public Ac(int currentNumber) :
        base(DeviceType.AC, currentNumber)
        {

        }
    }
}