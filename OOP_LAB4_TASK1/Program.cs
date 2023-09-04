using System;

namespace OOP_LAB4_TASK1
{
    public enum VehicleType
    {
        SEDAN,
        MOTOR_BIKE,
        SEVEN_SEATER
    }
    public interface Ivehicle
    {


        public int perHeadFare();
        public bool canTakeTrip();

    }
    class Program
    {
        [STAThread]
        static void Main(String[] args)
        {
           vehicleManager vehicle_manager= new vehicleManager();

           vehicle_manager.vehicle();

        }
    }
}