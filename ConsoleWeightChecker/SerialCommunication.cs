using System;
using System.IO.Ports;

namespace ConsoleWeightChecker
{
    static class SerialCommunication
    {
        private static bool itWorked = false;

        public static bool ItWorked
        {
            get { return itWorked; }
        }

        public static void ConnectToSerial(SerialPort _serialPort)
        {
            while (!SerialCommunication.ItWorked) //Keep trying
            {
                try
                {
                    _serialPort.BaudRate = 19200;
                    _serialPort.Parity = Parity.None;
                    _serialPort.DataBits = 8;
                    _serialPort.StopBits = StopBits.One;
                    _serialPort.Handshake = Handshake.RequestToSend;
                    Console.WriteLine("Input COM Number");
                    _serialPort.PortName = "COM" + Console.ReadLine().ToString();
                    _serialPort.Open();
                    itWorked = true;
                }
                catch
                {
                    Console.WriteLine("Somethings wrong");
                }
            }
        }
    }
}
