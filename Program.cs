using System;
using System.Collections.Generic;
using switchBordNew.models;


namespace switchBordNew
{

    class Program
    {
        private static int TakePositiveInteger()
        {
            int value = 0;
            bool check = true;
            while (check)
            {
                try
                {
                    value = Convert.ToInt32(Console.ReadLine());
                    if (value < 0)
                    {
                        Console.WriteLine("please enter a whole number");
                        break;
                    }
                    else
                    {
                        check = false;
                    }
                }
                catch (System.InvalidCastException i)
                {
                    Console.WriteLine(i + "please enter numbers only");
                }
            }
            return value;
        }
        public static void DescribeDevices(ref List<Device> devices)
        {
            int count = 1;
            foreach (var device in devices)
            {
                Console.Write(count.ToString() + " ");
                device.GetStatus();
                count++;
            }
        }
        static void Main(string[] args)
        {
            List<Device> devices = new List<Device>();

            int loopCount;

            Console.WriteLine("Enter the number of fans");
            //loopCount = Convert.ToInt32(Console.ReadLine());
            loopCount = TakePositiveInteger();
            for (int i = 0; i < loopCount; i++)
            {
                devices.Add(new Fan(i + 1));
                //devices.Add(new Device(DeviceType.FAN, i + 1));
            }
            Console.WriteLine("Enter the number of acs");
            //loopCount = Convert.ToInt32(Console.ReadLine());
            loopCount = TakePositiveInteger();
            for (int i = 0; i < loopCount; i++)
            {
                devices.Add(new Ac(i + 1));
            }
            Console.WriteLine("Enter the number of bulbs");
            //loopCount = Convert.ToInt32(Console.ReadLine());
            loopCount = TakePositiveInteger();
            for (int i = 0; i < loopCount; i++)
            {
                devices.Add(new Bulb(i + 1));
            }

            while (true)
            {
                DescribeDevices(ref devices);
                Console.WriteLine("enter the device number to select it");

                int temp = Convert.ToInt32(Console.ReadLine()) - 1;
                while (true)
                {
                    if (temp < devices.Count)
                    {
                        Console.WriteLine("1.Switch the state of " + devices[temp].GetDeviceType() + " " + devices[temp].CurrentNumber.ToString() + "\n2.Back\n");
                        Console.WriteLine("choose the option above");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            devices[temp].ToggleState();
                            break;
                        }
                        else if (choice == 2)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter a valid menu option");
                        }
                    }
                    else
                    {
                        Console.WriteLine("enter the valid number between 1 and " + devices.Count.ToString());
                        temp = Convert.ToInt32(Console.ReadLine()) - 1;
                    }


                }

                Console.WriteLine("Enter y (or) n to continue (or) discontinue");
                if (Convert.ToString(Console.ReadLine()) == "n")
                {
                    break;
                }

            }
        }
    }
}
