using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400095
{
    internal class MesinKopi
    {

        enum State { Off, Standby, Brewing, Maintenance }

        private State state = State.Off;

        public void PowerOn()
        {
            if (state == State.Off)
            {
                state = State.Standby;
                Console.WriteLine("Mesin Off berubah menjadi standby");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }

        public void StartBrew()
        {
            if (state == State.Standby)
            {
                state = State.Brewing;
                Console.WriteLine("Mesin Standby berubah menjadi Brewing");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }

        public void FinishBrew()
        {
            if (state == State.Brewing)
            {
                state = State.Standby;
                Console.WriteLine("Mesin Brewing berubah menjadi Standby");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }

        public void StartMaintenance()
        {
            if (state == State.Standby)
            {
                state = State.Maintenance;
                Console.WriteLine("Mesin Standby berubah menjadi Maintenance");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }

        public void FinishMaintenance()
        {
            if (state == State.Maintenance)
            {
                state = State.Standby;
                Console.WriteLine("Mesin Maintenance berubah menjadi Standby");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }

        public void PowerOff()
        {
            if (state == State.Standby)
            {
                state = State.Off;
                Console.WriteLine("Mesin Standby berubah menjadi Off");
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }
    }
}
